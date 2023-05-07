using LabCaseus.Analise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.Entities
{
    public class EspecificacaoMetodologiaAnaliseMapping : IEntityTypeConfiguration<EspecificacaoMetodologiaAnalise>
    {
        public void Configure(EntityTypeBuilder<EspecificacaoMetodologiaAnalise> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_especificacao_metodologia_analise")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_especificacao_metodologia_analise")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.CertificadoAnaliseId)
               .HasColumnName("fk_cod_certificado_analise")
               .IsRequired();

            builder.Property(e => e.EspecificacaoMetodologiaId)
               .HasColumnName("fk_cod_especificacao_metodologia")
               .IsRequired();

            builder.ToTable("tb_especificacao_metodologia_analise");

            builder.HasData(new List<EspecificacaoMetodologiaAnalise>()
            {
                new EspecificacaoMetodologiaAnalise(1, 1, 1),
                new EspecificacaoMetodologiaAnalise(2, 1, 2)
            });
        }
    }
}