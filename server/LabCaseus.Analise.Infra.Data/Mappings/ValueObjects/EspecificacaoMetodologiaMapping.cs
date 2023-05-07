using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.ValueObjects
{
    public class EspecificacaoMetodologiaMapping : IEntityTypeConfiguration<EspecificacaoMetodologia>
    {
        public void Configure(EntityTypeBuilder<EspecificacaoMetodologia> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_especificacao_metodologia")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_especificacao_metodologia")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.Descricao)
                .HasColumnName("des_especificacao_metodologia")
                .HasMaxLength(500)
                .IsRequired();

            builder.ToTable("tb_especificacao_metodologia");

            builder.HasData(new List<EspecificacaoMetodologia>()
            {
                new EspecificacaoMetodologia(1, "Resolução CONAMA nº 274 de 29 de novembro de 2000."),
                new EspecificacaoMetodologia(2, "Standard Methods for the Examination of Water and Wastewater - American Public Health Association (APHA).")
            });
        }
    }
}