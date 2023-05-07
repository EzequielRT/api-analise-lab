﻿using LabCaseus.Analise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabCaseus.Analise.Infra.Data.Mappings.Entities
{
    public class CertificadoAnaliseMapping : IEntityTypeConfiguration<CertificadoAnalise>
    {
        public void Configure(EntityTypeBuilder<CertificadoAnalise> builder)
        {
            builder.HasKey(e => e.Id)
                .IsClustered();

            builder.Property(e => e.Id)
                .HasColumnName("cod_certificado_analise")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UId)
                .HasColumnName("uid_certificado_analise")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(e => e.Numero)
                .HasColumnName("des_numero")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Amostra)
                .HasColumnName("des_amostra")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.LocalColeta)
                .HasColumnName("des_local_coleta")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.DataHoraColeta)
                .HasColumnName("data_hora_coleta")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.ResponsavelColeta)
                .HasColumnName("des_responsavel_coleta")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(e => e.FuncaoAgua)
                .HasColumnName("des_funcao_agua")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(e => e.DataHoraRecebimentoCaseus)
                .HasColumnName("data_hora_recebimento_caseus")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.DataHoraInicioAnalise)
                .HasColumnName("data_hora_inicio_analise")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.DataHoraTerminoAnalise)
                .HasColumnName("data_hora_termino_analise")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.ParecerFarmaceutico)
                .HasColumnName("des_parecer_farmaceutico")
                .HasMaxLength(350)
                .IsRequired();

            builder.Property(e => e.ClienteId)
               .HasColumnName("fk_cod_cliente")
               .IsRequired();

            builder.Property(e => e.FarmaceuticoResponsavelId)
               .HasColumnName("fk_cod_farmaceutico_responsavel")
               .IsRequired();

            builder.Property(e => e.AnaliseFisicoQuimicaId)
               .HasColumnName("fk_cod_analise_fisico_quimica")
               .IsRequired();

            builder.Property(e => e.AnaliseMicrobiologicaId)
               .HasColumnName("fk_cod_analise_microbiologica")
               .IsRequired();

            builder.ToTable("tb_certificado_analise");

            builder.HasData(new CertificadoAnalise(
                1,
                "AGUA 056/20",
                "Água de recreação",
                "Piscina Grande",
                new DateTime(2020, 2, 3, 8, 20, 0),
                "Aparecida Amadeu",
                "Lazer",
                new DateTime(2020, 2, 3),
                new DateTime(2020, 2, 3),
                new DateTime(2020, 2, 5),
                "A amostra analisada atende às especificações descritas.",
                1,
                1,
                1,
                1));
        }
    }
}