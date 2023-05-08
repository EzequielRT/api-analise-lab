using LabCaseus.Analise.Domain.Repositories;
using LabCaseus.Analise.Infra.Data.Context;
using LabCaseus.Analise.Infra.Data.Repositories;
using LabCaseus.Analise.Infra.Data.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LabCaseus.Analise.Infra.Data
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddPersistence(configuration)
                .AddUnitOfWork()
                .AddRepositories();

            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("LabCaseusCs");

            services.AddDbContext<ApplicationDbContext>(options =>
            options
                .UseSqlServer(connectionString)
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole())));

            // Banco Sqlite para testes
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=LabCaseusDbSqlite.db"));

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICertificadoAnaliseRepository, CertificadoAnaliseRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();            

            return services;
        }

        private static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}