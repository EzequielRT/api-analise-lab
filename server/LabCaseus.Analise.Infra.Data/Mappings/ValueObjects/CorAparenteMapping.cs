using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.ValueObjects
{
    public class CorAparenteMapping : IEntityTypeConfiguration<CorAparente>
    {
        public void Configure(EntityTypeBuilder<CorAparente> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_cor_aparente")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_cor_aparente")
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

            builder.ToTable("tb_cor_aparente");

            builder.HasData(new CorAparente(1, "Máximo 75 uH", "0,0 uH"));
        }
    }

}