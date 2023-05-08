using LabCaseus.Analise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.Entities
{
    public class FarmaceuticoMapping : IEntityTypeConfiguration<Farmaceutico>
    {
        public void Configure(EntityTypeBuilder<Farmaceutico> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_farmaceutico")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_farmaceutico")
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

            builder.ToTable("tb_farmaceutico");

            builder.HasData(new Farmaceutico(1, "José Carlos de Almeida Junior", "Farmacêutico Bioquímico", "CRQ/MG 02419351"));
        }
    }
}