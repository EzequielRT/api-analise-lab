using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.ValueObjects
{
    public class SolidosTotaisDissolvidosMapping : IEntityTypeConfiguration<SolidosTotaisDissolvidos>
    {
        public void Configure(EntityTypeBuilder<SolidosTotaisDissolvidos> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_solidos_totais_dissolvidos")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_solidos_totais_dissolvidos")
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

            builder.ToTable("tb_solidos_totais_dissolvidos");

            builder.HasData(new SolidosTotaisDissolvidos(1, "Máximo 500 mg/L", "229,0 mg/L"));
        }
    }
}