using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.ValueObjects
{
    public class TurbidezMapping : IEntityTypeConfiguration<Turbidez>
    {
        public void Configure(EntityTypeBuilder<Turbidez> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_turbidez")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_turbidez")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.Especificacao)
                .HasColumnName("des_especificacao")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(e => e.Resultado)
                .HasColumnName("des_resultado")
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("tb_turbidez");

            builder.HasData(new Turbidez(1, "Máximo 40 uT", "0,8 uT"));
        }
    }
}