using LabCaseus.Analise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.Entities
{
    public class AnaliseMicrobiologicaMapping : IEntityTypeConfiguration<AnaliseMicrobiologica>
    {
        public void Configure(EntityTypeBuilder<AnaliseMicrobiologica> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_analise_microbiologica")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_analise_microbiologica")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.ColiformeTermotoleranteId)
               .HasColumnName("fk_cod_coliforme_termotolerante")
               .IsRequired();

            builder.Property(e => e.CertificadoAnaliseId)
               .HasColumnName("fk_cod_certificado_analise")
               .IsRequired();

            builder
                .HasOne(a => a.CertificadoAnalise)
                .WithOne(c => c.AnaliseMicrobiologica)
                .HasForeignKey<CertificadoAnalise>(c => c.AnaliseMicrobiologicaId);

            builder.ToTable("tb_analise_microbiologica");

            builder.HasData(new AnaliseMicrobiologica(1, 1, 1));
        }
    }
}