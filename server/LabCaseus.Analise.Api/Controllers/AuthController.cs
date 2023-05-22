using LabCaseus.Analise.Api.Models;
using LabCaseus.Analise.Application.Mediator.Notifications;
using LabCaseus.Analise.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace LabCaseus.Analise.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/")]
    public class AuthController : ApiController
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private SignInManager<IdentityUser> _signInManager;

        public AuthController(
            ILogger<AuthController> logger,
            INotificationHandler<DomainNotification> notifications,
            IConfiguration configuration,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<IdentityUser> signInManager) : base(logger, notifications)
        {
            _configuration = configuration;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("auth/registro")]
        [AllowAnonymous]
        public async Task<IActionResult> CriarUsuarioAsync([FromBody] CreateUserModel model)
        {
            var userExists = await _userManager.FindByEmailAsync(model.Email);

            if (userExists is not null)
            {
                return BadRequest(new
                {
                    success = false,
                    errors = "Usuário já existe!"
                });
            }

            IdentityUser user = new()
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = model.Email,
                UserName = model.Username
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(new
                {
                    success = false,
                    errors = "Erro ao criar usuário"
                });
            }

            if (model.Email.Equals("admin@technochem.com") && model.Password.Equals("admin@2023"))
            {
                await AddToRoleAsync(user, UserRoles.Admin);
            }
            else
            {
                await AddToRoleAsync(user, UserRoles.User);
            }

            return ResponseApiOk("Usuário criado com sucesso!");
        }

        [HttpPost]
        [Route("auth/login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromBody] LoginModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user is not null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var authClaims = new List<Claim>
                {
                    new (ClaimTypes.Name, user.UserName),
                    new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var userRoles = await _userManager.GetRolesAsync(user);

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new(ClaimTypes.Role, userRole));
                }

                var token = GetToken(authClaims, userRoles.First());
                return ResponseApiOk(token);
            }

            return Unauthorized(new
            {
                success = false,
                errors = "Login falhou!"
            });
        }

        [HttpPost]
        [Route("auth/logout")]
        [Authorize]
        public async Task<IActionResult> LogoutAsync()
        {
            var result = _signInManager.SignOutAsync();

            if (!result.IsCompletedSuccessfully)
            {
                return BadRequest(new
                {
                    success = false,
                    errors = "Logout falhou!"
                });
            }

            return Ok();
        }

        private TokenModel GetToken(List<Claim> authClaims, string role)
        {
            var authSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(24),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return new()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Profile = role,
                ValidTo = token.ValidTo
            };
        }

        private async Task AddToRoleAsync(IdentityUser user, string role)
        {
            if (!await _roleManager.RoleExistsAsync(role))
                await _roleManager.CreateAsync(new(role));

            await _userManager.AddToRoleAsync(user, role);
        }
    }
}