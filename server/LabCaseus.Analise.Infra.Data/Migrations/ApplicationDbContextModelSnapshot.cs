﻿// <auto-generated />
using System;
using LabCaseus.Analise.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabCaseus.Analise.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.AnaliseFisicoQuimica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_analise_fisico_quimica");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AspectoVisualId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_aspecto_visual");

                    b.Property<int>("CertificadoAnaliseId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_certificado_analise");

                    b.Property<int>("CloretoId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_cloreto");

                    b.Property<int>("CloroResidualLivreId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_cloreto_visual");

                    b.Property<int>("CorAparenteId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_cor_aparente");

                    b.Property<int>("FerroId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_ferro");

                    b.Property<int>("PhId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_ph");

                    b.Property<int>("SolidosTotaisDissolvidosId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_solidos_totais_dissolvidos");

                    b.Property<int>("TurbidezId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_turbidez");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_analise_fisico_quimica");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("AspectoVisualId");

                    b.HasIndex("CertificadoAnaliseId")
                        .IsUnique();

                    b.HasIndex("CloretoId");

                    b.HasIndex("CloroResidualLivreId");

                    b.HasIndex("CorAparenteId");

                    b.HasIndex("FerroId");

                    b.HasIndex("PhId");

                    b.HasIndex("SolidosTotaisDissolvidosId");

                    b.HasIndex("TurbidezId");

                    b.ToTable("tb_analise_fisico_quimica", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AspectoVisualId = 1,
                            CertificadoAnaliseId = 1,
                            CloretoId = 1,
                            CloroResidualLivreId = 1,
                            CorAparenteId = 1,
                            FerroId = 1,
                            PhId = 1,
                            SolidosTotaisDissolvidosId = 1,
                            TurbidezId = 1,
                            UId = new Guid("b88e3474-33da-4487-9820-f2b8ac26a8bc")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.AnaliseMicrobiologica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_analise_microbiologica");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertificadoAnaliseId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_certificado_analise");

                    b.Property<int>("ColiformeTermotoleranteId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_coliforme_termotolerante");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_analise_microbiologica");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("CertificadoAnaliseId")
                        .IsUnique();

                    b.HasIndex("ColiformeTermotoleranteId");

                    b.ToTable("tb_analise_microbiologica", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CertificadoAnaliseId = 1,
                            ColiformeTermotoleranteId = 1,
                            UId = new Guid("a7369928-a966-4a8a-bbc7-d7d4e7fd1c15")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.CertificadoAnalise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_certificado_analise");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amostra")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("des_amostra");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_cliente");

                    b.Property<DateTime>("DataHoraColeta")
                        .HasColumnType("datetime")
                        .HasColumnName("data_hora_coleta");

                    b.Property<DateTime>("DataHoraInicioAnalise")
                        .HasColumnType("datetime")
                        .HasColumnName("data_hora_inicio_analise");

                    b.Property<DateTime>("DataHoraRecebimentoCaseus")
                        .HasColumnType("datetime")
                        .HasColumnName("data_hora_recebimento_caseus");

                    b.Property<DateTime>("DataHoraTerminoAnalise")
                        .HasColumnType("datetime")
                        .HasColumnName("data_hora_termino_analise");

                    b.Property<int>("FarmaceuticoResponsavelId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_farmaceutico_responsavel");

                    b.Property<string>("FuncaoAgua")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_funcao_agua");

                    b.Property<string>("LocalColeta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("des_local_coleta");

                    b.Property<string>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_numero");

                    b.Property<string>("ParecerFarmaceutico")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)")
                        .HasColumnName("des_parecer_farmaceutico");

                    b.Property<string>("ResponsavelColeta")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("des_responsavel_coleta");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_certificado_analise");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("ClienteId");

                    b.HasIndex("FarmaceuticoResponsavelId");

                    b.ToTable("tb_certificado_analise", null, t =>
                        {
                            t.HasTrigger("Trg_tb_certificado_analise_Insert");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amostra = "Água de recreação",
                            ClienteId = 1,
                            DataHoraColeta = new DateTime(2020, 2, 3, 8, 20, 0, 0, DateTimeKind.Unspecified),
                            DataHoraInicioAnalise = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraRecebimentoCaseus = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraTerminoAnalise = new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmaceuticoResponsavelId = 1,
                            FuncaoAgua = "Lazer",
                            LocalColeta = "Piscina Grande",
                            ParecerFarmaceutico = "A amostra analisada atende às especificações descritas.",
                            ResponsavelColeta = "Aparecida Amadeu",
                            UId = new Guid("91212d98-fbda-4906-a6f1-b1e09a106505")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_cliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_cnpj");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("des_endereco");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("des_razao_social");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_cliente");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_cliente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cnpj = "19.532.464/0001-77",
                            Endereco = "Avenida Cel. Antônio Augusto de Souza 49 - Cataguases - MG",
                            RazaoSocial = "Clube do Remo",
                            UId = new Guid("f9acee48-bf52-4920-8ba2-315f4c62b44d")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.EspecificacaoMetodologiaAnalise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_especificacao_metodologia_analise");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CertificadoAnaliseId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_certificado_analise");

                    b.Property<int>("EspecificacaoMetodologiaId")
                        .HasColumnType("int")
                        .HasColumnName("fk_cod_especificacao_metodologia");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_especificacao_metodologia_analise");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("CertificadoAnaliseId");

                    b.HasIndex("EspecificacaoMetodologiaId");

                    b.ToTable("tb_especificacao_metodologia_analise", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CertificadoAnaliseId = 1,
                            EspecificacaoMetodologiaId = 1,
                            UId = new Guid("b84daa3b-eed9-400a-a610-e347e6979098")
                        },
                        new
                        {
                            Id = 2,
                            CertificadoAnaliseId = 1,
                            EspecificacaoMetodologiaId = 2,
                            UId = new Guid("eb6ed0f2-d8bf-4443-9f30-0d51bd51d116")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.Farmaceutico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_farmaceutico");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FarmaceuticoEspecialidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("des_farmaceutico_especialidade");

                    b.Property<string>("FarmaceuticoNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("des_farmaceutico_nome");

                    b.Property<string>("FarmaceuticoRegistroCrq")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("des_farmaceutico_registro_crq");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_farmaceutico");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_farmaceutico", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FarmaceuticoEspecialidade = "Farmacêutico Bioquímico",
                            FarmaceuticoNome = "José Carlos de Almeida Junior",
                            FarmaceuticoRegistroCrq = "CRQ/MG 02419351",
                            UId = new Guid("fdedab3f-9899-4a80-9f7a-65a376c52541")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.AspectoVisual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_aspecto_visual");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_aspecto_visual");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_aspecto_visual", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Ausência de floração de algas ou outros organismos",
                            Resultado = "De acordo",
                            UId = new Guid("cb9f5919-5b1a-4c62-a4fd-b56c21f2aba0")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.Cloreto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_cloreto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_cloreto");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_cloreto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Máximo 250 mg/L",
                            Resultado = "31,8 mg/L",
                            UId = new Guid("b41718eb-b135-44c8-9ecb-b35543af4832")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.CloroResidualLivre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_cloro_residual_livre");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_cloro_residual_livre");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_cloro_residual_livre", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Mínimo 1,0 mg/L",
                            Resultado = "4,2 mg/L",
                            UId = new Guid("9278a5a5-dd32-49c5-800b-5f8be676705b")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.ColiformeTermotolerante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_coliforme_termotolerante");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_coliforme_termotolerante");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_coliforme_termotolerante", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Máximo 2500 UFC/mL",
                            Resultado = "<1,0 x 10¹ UFC/mL est",
                            UId = new Guid("b05ba693-4e4e-4f34-a820-39804ab2a0bd")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.CorAparente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_cor_aparente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_cor_aparente");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_cor_aparente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Máximo 75 uH",
                            Resultado = "0,0 uH",
                            UId = new Guid("8bd84850-edf1-4f52-bebc-27c4e4d5efe0")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.EspecificacaoMetodologia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_especificacao_metodologia");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("des_especificacao_metodologia");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_especificacao_metodologia");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_especificacao_metodologia", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Resolução CONAMA nº 274 de 29 de novembro de 2000.",
                            UId = new Guid("b46f591f-491c-4788-ace4-85b1ca1b719e")
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Standard Methods for the Examination of Water and Wastewater - American Public Health Association (APHA).",
                            UId = new Guid("cabba55e-4e1c-43c3-9e39-6e1b186e8d78")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.Ferro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_ferro");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_ferro");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_ferro", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Máximo 0,3 mg/L",
                            Resultado = "0,0 mg/L",
                            UId = new Guid("8a6ac95c-6dbc-4678-bc5c-4bc405900f05")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.Ph", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_ph");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_ph");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_ph", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "0,6 a 0,9",
                            Resultado = "7,8",
                            UId = new Guid("48f5f878-bdd8-45df-b736-7ea8b6d579fe")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.SolidosTotaisDissolvidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_solidos_totais_dissolvidos");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_solidos_totais_dissolvidos");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_solidos_totais_dissolvidos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Máximo 500 mg/L",
                            Resultado = "229,0 mg/L",
                            UId = new Guid("9cce2c76-2055-418f-be81-57711813b693")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.ValueObjects.Turbidez", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cod_turbidez");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especificacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("des_especificacao");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("des_resultado");

                    b.Property<Guid>("UId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("uid_turbidez");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("tb_turbidez", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especificacao = "Máximo 40 uT",
                            Resultado = "0,8 uT",
                            UId = new Guid("29d88302-00d6-4c28-9755-2f0ebb3b6a24")
                        });
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.AnaliseFisicoQuimica", b =>
                {
                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.AspectoVisual", "AspectoVisual")
                        .WithMany()
                        .HasForeignKey("AspectoVisualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.Entities.CertificadoAnalise", "CertificadoAnalise")
                        .WithOne("AnaliseFisicoQuimica")
                        .HasForeignKey("LabCaseus.Analise.Domain.Entities.AnaliseFisicoQuimica", "CertificadoAnaliseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.Cloreto", "Cloreto")
                        .WithMany()
                        .HasForeignKey("CloretoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.CloroResidualLivre", "CloroResidualLivre")
                        .WithMany()
                        .HasForeignKey("CloroResidualLivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.CorAparente", "CorAparente")
                        .WithMany()
                        .HasForeignKey("CorAparenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.Ferro", "Ferro")
                        .WithMany()
                        .HasForeignKey("FerroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.Ph", "Ph")
                        .WithMany()
                        .HasForeignKey("PhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.SolidosTotaisDissolvidos", "SolidosTotaisDissolvidos")
                        .WithMany()
                        .HasForeignKey("SolidosTotaisDissolvidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.Turbidez", "Turbidez")
                        .WithMany()
                        .HasForeignKey("TurbidezId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspectoVisual");

                    b.Navigation("CertificadoAnalise");

                    b.Navigation("Cloreto");

                    b.Navigation("CloroResidualLivre");

                    b.Navigation("CorAparente");

                    b.Navigation("Ferro");

                    b.Navigation("Ph");

                    b.Navigation("SolidosTotaisDissolvidos");

                    b.Navigation("Turbidez");
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.AnaliseMicrobiologica", b =>
                {
                    b.HasOne("LabCaseus.Analise.Domain.Entities.CertificadoAnalise", "CertificadoAnalise")
                        .WithOne("AnaliseMicrobiologica")
                        .HasForeignKey("LabCaseus.Analise.Domain.Entities.AnaliseMicrobiologica", "CertificadoAnaliseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.ColiformeTermotolerante", "ColiformeTermotolerante")
                        .WithMany()
                        .HasForeignKey("ColiformeTermotoleranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CertificadoAnalise");

                    b.Navigation("ColiformeTermotolerante");
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.CertificadoAnalise", b =>
                {
                    b.HasOne("LabCaseus.Analise.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.Entities.Farmaceutico", "FarmaceuticoResponsavel")
                        .WithMany()
                        .HasForeignKey("FarmaceuticoResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("FarmaceuticoResponsavel");
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.EspecificacaoMetodologiaAnalise", b =>
                {
                    b.HasOne("LabCaseus.Analise.Domain.Entities.CertificadoAnalise", "CertificadoAnalise")
                        .WithMany("EspecificacaosMetodologiasAnalise")
                        .HasForeignKey("CertificadoAnaliseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabCaseus.Analise.Domain.ValueObjects.EspecificacaoMetodologia", "EspecificacaoMetodologia")
                        .WithMany()
                        .HasForeignKey("EspecificacaoMetodologiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CertificadoAnalise");

                    b.Navigation("EspecificacaoMetodologia");
                });

            modelBuilder.Entity("LabCaseus.Analise.Domain.Entities.CertificadoAnalise", b =>
                {
                    b.Navigation("AnaliseFisicoQuimica");

                    b.Navigation("AnaliseMicrobiologica");

                    b.Navigation("EspecificacaosMetodologiasAnalise");
                });
#pragma warning restore 612, 618
        }
    }
}
