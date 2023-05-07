using LabCaseus.Analise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.Entities
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_cliente")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_cliente")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.RazaoSocial)
                .HasColumnName("des_razao_social")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Cnpj)
                .HasColumnName("des_cnpj")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Endereco)
                .HasColumnName("des_endereco")
                .HasMaxLength(250)
                .IsRequired();

            builder.ToTable("tb_cliente");

            builder.HasData(new Cliente(1, "Clube do Remo", "19.532.464/0001-77", "Avenida Cel. Antônio Augusto de Souza 49 - Cataguases - MG"));
        }
    }
}