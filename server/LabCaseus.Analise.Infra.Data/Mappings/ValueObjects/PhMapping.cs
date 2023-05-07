using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.ValueObjects
{
    public class PhMapping : IEntityTypeConfiguration<Ph>
    {
        public void Configure(EntityTypeBuilder<Ph> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_ph")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_ph")
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

            builder.ToTable("tb_ph");

            builder.HasData(new Ph(1, "0,6 a 0,9", "7,8"));
        }
    }
}