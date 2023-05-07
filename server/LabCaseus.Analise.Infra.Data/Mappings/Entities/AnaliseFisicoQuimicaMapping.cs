using LabCaseus.Analise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.Entities
{
    public class AnaliseFisicoQuimicaMapping : IEntityTypeConfiguration<AnaliseFisicoQuimica>
    {
        public void Configure(EntityTypeBuilder<AnaliseFisicoQuimica> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_analise_fisico_quimica")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_analise_fisico_quimica")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.CertificadoAnaliseId)
               .HasColumnName("fk_cod_certificado_analise")
               .IsRequired();

            builder.Property(e => e.PhId)
               .HasColumnName("fk_cod_ph")
               .IsRequired();

            builder.Property(e => e.FerroId)
               .HasColumnName("fk_cod_ferro")
               .IsRequired();

            builder.Property(e => e.TurbidezId)
              .HasColumnName("fk_cod_turbidez")
              .IsRequired();

            builder.Property(e => e.CloretoId)
              .HasColumnName("fk_cod_cloreto")
              .IsRequired();

            builder.Property(e => e.CorAparenteId)
              .HasColumnName("fk_cod_cor_aparente")
              .IsRequired();

            builder.Property(e => e.AspectoVisualId)
              .HasColumnName("fk_cod_aspecto_visual")
              .IsRequired();

            builder.Property(e => e.CloroResidualLivreId)
              .HasColumnName("fk_cod_cloreto_visual")
              .IsRequired();

            builder.Property(e => e.SolidosTotaisDissolvidosId)
              .HasColumnName("fk_cod_solidos_totais_dissolvidos")
              .IsRequired();

            builder
                .HasOne(a => a.CertificadoAnalise)
                .WithOne(c => c.AnaliseFisicoQuimica)
                .HasForeignKey<CertificadoAnalise>(c => c.AnaliseFisicoQuimicaId);

            builder.ToTable("tb_analise_fisico_quimica");

            builder.HasData(new AnaliseFisicoQuimica(1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
        }
    }
}