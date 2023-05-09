using System.ComponentModel.DataAnnotations;

namespace LabCaseus.Analise.Api.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "o e-mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        public string Password { get; set; }
    }
}