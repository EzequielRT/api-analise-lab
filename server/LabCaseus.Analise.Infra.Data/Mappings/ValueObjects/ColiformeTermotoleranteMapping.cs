using LabCaseus.Analise.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LabCaseus.Analise.Infra.Data.Mappings.ValueObjects
{
    public class ColiformeTermotoleranteMapping : IEntityTypeConfiguration<ColiformeTermotolerante>
    {
        public void Configure(EntityTypeBuilder<ColiformeTermotolerante> builder)
        {
            builder.HasKey(e => e.Id)
                   .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_coliforme_termotolerante")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_coliforme_termotolerante")
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

            builder.ToTable("tb_coliforme_termotolerante");

            builder.HasData(new ColiformeTermotolerante(1, "Máximo 2500 UFC/mL", "<1,0 x 10¹ UFC/mL est"));
        }
    }
}