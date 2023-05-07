using LabCaseus.Analise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.Entities
{
    public class FarmaceuticoResponsavelMapping : IEntityTypeConfiguration<FarmaceuticoResponsavel>
    {
        public void Configure(EntityTypeBuilder<FarmaceuticoResponsavel> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_farmaceutico_responsavel")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_farmaceutico_responsavel")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.FarmaceuticoNome)
                .HasColumnName("des_farmaceutico_nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.FarmaceuticoEspecialidade)
                .HasColumnName("des_farmaceutico_especialidade")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.FarmaceuticoRegistroCrq)
                .HasColumnName("des_farmaceutico_registro_crq")
                .HasMaxLength(30)
                .IsRequired();

            builder.ToTable("tb_farmaceutico_responsavel");

            builder.HasData(new FarmaceuticoResponsavel(1, "José Carlos de Almeida Junior", "Farmacêutico Bioquímico", "CRQ/MG 02419351"));
        }
    }
}