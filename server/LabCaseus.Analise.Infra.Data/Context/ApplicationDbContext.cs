using LabCaseus.Analise.Domain.Entities;
using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LabCaseus.Analise.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        #region Entities
        public DbSet<AnaliseFisicoQuimica> AnalisesFisicoQuimicas { get; set; }
        public DbSet<AnaliseMicrobiologica> AnalisesMicrobiologicas { get; set; }
        public DbSet<CertificadoAnalise> CertificadosAnalises { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EspecificacaoMetodologiaAnalise> EspecificacoesMetodologiaAnalise { get; set; }
        public DbSet<FarmaceuticoResponsavel> FarmaceuticosResponsaveis { get; set; }
        #endregion

        #region ValueObjects
        public DbSet<AspectoVisual> AspectosVisuais { get; set; }
        public DbSet<Cloreto> Cloretos { get; set; }
        public DbSet<CloroResidualLivre> ClorosResiduaisLivres { get; set; }
        public DbSet<ColiformeTermotolerante> ColiformesTermotolerantes { get; set; }
        public DbSet<CorAparente> CoresAparentes { get; set; }
        public DbSet<EspecificacaoMetodologia> EspecificacoesMetodologias { get; set; }
        public DbSet<Ferro> Ferros { get; set; }
        public DbSet<Ph> Phs { get; set; }
        public DbSet<SolidosTotaisDissolvidos> SolidosTotaisDissolvidos { get; set; }
        public DbSet<Turbidez> Turbidez { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}