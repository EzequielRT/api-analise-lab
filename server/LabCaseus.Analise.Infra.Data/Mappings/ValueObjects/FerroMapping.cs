using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.ValueObjects
{
    public class FerroMapping : IEntityTypeConfiguration<Ferro>
    {
        public void Configure(EntityTypeBuilder<Ferro> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_ferro")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_ferro")
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

            builder.ToTable("tb_ferro");

            builder.HasData(new Ferro(1, "Máximo 0,3 mg/L", "0,0 mg/L"));
        }
    }
}