using LabCaseus.Analise.Infra.Data.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System.Text;
using System.Text.Json.Serialization;

namespace LabCaseus.Analise.Api.Configurations
{
    public static class ApiConfiguration
    {
        public static void AddApiConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddMvcCore(o =>
                {
                    o.OutputFormatters.Remove(new XmlDataContractSerializerOutputFormatter());
                })
                .AddJsonOptions(o =>
                {
                    o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                })
                .AddCors(options =>
                {
                    options.AddPolicy("All",
                        builder =>
                            builder
                                .AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader());
                })
                .AddAuthorization()
                .AddFormatterMappings();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.SaveToken = true;
                x.RequireHttpsMetadata = false;
                x.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            });

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
        }

        public static void UseApiConfiguration(this WebApplication app)
        {
            app.UseCors("All");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
        }

        public static void AddIdentityConfiguration(this WebApplicationBuilder builder)
        {
            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<UserDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            });
        }

        public static void AddSerilogConfiguration(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
            {
                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .WriteTo.MSSqlServer(configuration.GetConnectionString("LabCaseusCs"),
                        sinkOptions: new MSSqlServerSinkOptions()
                        {
                            AutoCreateSqlTable = true,
                            TableName = "tb_logs"
                        })
                    .WriteTo.Console()
                    .MinimumLevel.Error()
                    .CreateLogger();
            }).UseSerilog();
        }
    }
}