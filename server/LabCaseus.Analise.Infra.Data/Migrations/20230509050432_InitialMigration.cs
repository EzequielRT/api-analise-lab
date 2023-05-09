using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LabCaseus.Analise.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "tb_aspecto_visual",
                schema: "dbo",
                columns: table => new
                {
                    cod_aspecto_visual = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_aspecto_visual = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_aspecto_visual", x => x.cod_aspecto_visual)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_cliente",
                schema: "dbo",
                columns: table => new
                {
                    cod_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_razao_social = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    des_cnpj = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    des_endereco = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    uid_cliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cliente", x => x.cod_cliente)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_cloreto",
                schema: "dbo",
                columns: table => new
                {
                    cod_cloreto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_cloreto = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cloreto", x => x.cod_cloreto)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_cloro_residual_livre",
                schema: "dbo",
                columns: table => new
                {
                    cod_cloro_residual_livre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_cloro_residual_livre = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cloro_residual_livre", x => x.cod_cloro_residual_livre)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_coliforme_termotolerante",
                schema: "dbo",
                columns: table => new
                {
                    cod_coliforme_termotolerante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_coliforme_termotolerante = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_coliforme_termotolerante", x => x.cod_coliforme_termotolerante)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_cor_aparente",
                schema: "dbo",
                columns: table => new
                {
                    cod_cor_aparente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_cor_aparente = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cor_aparente", x => x.cod_cor_aparente)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_especificacao_metodologia",
                schema: "dbo",
                columns: table => new
                {
                    cod_especificacao_metodologia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao_metodologia = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    uid_especificacao_metodologia = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_especificacao_metodologia", x => x.cod_especificacao_metodologia)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_farmaceutico",
                schema: "dbo",
                columns: table => new
                {
                    cod_farmaceutico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_farmaceutico_nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    des_farmaceutico_especialidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    des_farmaceutico_registro_crq = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    uid_farmaceutico = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_farmaceutico", x => x.cod_farmaceutico)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_ferro",
                schema: "dbo",
                columns: table => new
                {
                    cod_ferro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_ferro = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ferro", x => x.cod_ferro)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_ph",
                schema: "dbo",
                columns: table => new
                {
                    cod_ph = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_ph = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ph", x => x.cod_ph)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_solidos_totais_dissolvidos",
                schema: "dbo",
                columns: table => new
                {
                    cod_solidos_totais_dissolvidos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_solidos_totais_dissolvidos = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_solidos_totais_dissolvidos", x => x.cod_solidos_totais_dissolvidos)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_turbidez",
                schema: "dbo",
                columns: table => new
                {
                    cod_turbidez = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_especificacao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    des_resultado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uid_turbidez = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_turbidez", x => x.cod_turbidez)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "tb_certificado_analise",
                schema: "dbo",
                columns: table => new
                {
                    cod_certificado_analise = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    des_numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    des_amostra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    des_local_coleta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    data_hora_coleta = table.Column<DateTime>(type: "datetime", nullable: false),
                    des_responsavel_coleta = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    des_funcao_agua = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    data_hora_recebimento_caseus = table.Column<DateTime>(type: "datetime", nullable: false),
                    data_hora_inicio_analise = table.Column<DateTime>(type: "datetime", nullable: false),
                    data_hora_termino_analise = table.Column<DateTime>(type: "datetime", nullable: false),
                    des_parecer_farmaceutico = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    fk_cod_cliente = table.Column<int>(type: "int", nullable: false),
                    fk_cod_farmaceutico_responsavel = table.Column<int>(type: "int", nullable: false),
                    uid_certificado_analise = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_certificado_analise", x => x.cod_certificado_analise)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_tb_certificado_analise_tb_cliente_fk_cod_cliente",
                        column: x => x.fk_cod_cliente,
                        principalSchema: "dbo",
                        principalTable: "tb_cliente",
                        principalColumn: "cod_cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_certificado_analise_tb_farmaceutico_fk_cod_farmaceutico_responsavel",
                        column: x => x.fk_cod_farmaceutico_responsavel,
                        principalSchema: "dbo",
                        principalTable: "tb_farmaceutico",
                        principalColumn: "cod_farmaceutico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_analise_fisico_quimica",
                schema: "dbo",
                columns: table => new
                {
                    cod_analise_fisico_quimica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_cod_ph = table.Column<int>(type: "int", nullable: false),
                    fk_cod_ferro = table.Column<int>(type: "int", nullable: false),
                    fk_cod_turbidez = table.Column<int>(type: "int", nullable: false),
                    fk_cod_cloreto = table.Column<int>(type: "int", nullable: false),
                    fk_cod_cor_aparente = table.Column<int>(type: "int", nullable: false),
                    fk_cod_aspecto_visual = table.Column<int>(type: "int", nullable: false),
                    fk_cod_cloreto_visual = table.Column<int>(type: "int", nullable: false),
                    fk_cod_solidos_totais_dissolvidos = table.Column<int>(type: "int", nullable: false),
                    fk_cod_certificado_analise = table.Column<int>(type: "int", nullable: false),
                    uid_analise_fisico_quimica = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_analise_fisico_quimica", x => x.cod_analise_fisico_quimica)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_aspecto_visual_fk_cod_aspecto_visual",
                        column: x => x.fk_cod_aspecto_visual,
                        principalSchema: "dbo",
                        principalTable: "tb_aspecto_visual",
                        principalColumn: "cod_aspecto_visual",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_certificado_analise_fk_cod_certificado_analise",
                        column: x => x.fk_cod_certificado_analise,
                        principalSchema: "dbo",
                        principalTable: "tb_certificado_analise",
                        principalColumn: "cod_certificado_analise",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_cloreto_fk_cod_cloreto",
                        column: x => x.fk_cod_cloreto,
                        principalSchema: "dbo",
                        principalTable: "tb_cloreto",
                        principalColumn: "cod_cloreto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_cloro_residual_livre_fk_cod_cloreto_visual",
                        column: x => x.fk_cod_cloreto_visual,
                        principalSchema: "dbo",
                        principalTable: "tb_cloro_residual_livre",
                        principalColumn: "cod_cloro_residual_livre",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_cor_aparente_fk_cod_cor_aparente",
                        column: x => x.fk_cod_cor_aparente,
                        principalSchema: "dbo",
                        principalTable: "tb_cor_aparente",
                        principalColumn: "cod_cor_aparente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_ferro_fk_cod_ferro",
                        column: x => x.fk_cod_ferro,
                        principalSchema: "dbo",
                        principalTable: "tb_ferro",
                        principalColumn: "cod_ferro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_ph_fk_cod_ph",
                        column: x => x.fk_cod_ph,
                        principalSchema: "dbo",
                        principalTable: "tb_ph",
                        principalColumn: "cod_ph",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_solidos_totais_dissolvidos_fk_cod_solidos_totais_dissolvidos",
                        column: x => x.fk_cod_solidos_totais_dissolvidos,
                        principalSchema: "dbo",
                        principalTable: "tb_solidos_totais_dissolvidos",
                        principalColumn: "cod_solidos_totais_dissolvidos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_fisico_quimica_tb_turbidez_fk_cod_turbidez",
                        column: x => x.fk_cod_turbidez,
                        principalSchema: "dbo",
                        principalTable: "tb_turbidez",
                        principalColumn: "cod_turbidez",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_analise_microbiologica",
                schema: "dbo",
                columns: table => new
                {
                    cod_analise_microbiologica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_cod_coliforme_termotolerante = table.Column<int>(type: "int", nullable: false),
                    fk_cod_certificado_analise = table.Column<int>(type: "int", nullable: false),
                    uid_analise_microbiologica = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_analise_microbiologica", x => x.cod_analise_microbiologica)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_tb_analise_microbiologica_tb_certificado_analise_fk_cod_certificado_analise",
                        column: x => x.fk_cod_certificado_analise,
                        principalSchema: "dbo",
                        principalTable: "tb_certificado_analise",
                        principalColumn: "cod_certificado_analise",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_analise_microbiologica_tb_coliforme_termotolerante_fk_cod_coliforme_termotolerante",
                        column: x => x.fk_cod_coliforme_termotolerante,
                        principalSchema: "dbo",
                        principalTable: "tb_coliforme_termotolerante",
                        principalColumn: "cod_coliforme_termotolerante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_especificacao_metodologia_analise",
                schema: "dbo",
                columns: table => new
                {
                    cod_especificacao_metodologia_analise = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_cod_certificado_analise = table.Column<int>(type: "int", nullable: false),
                    fk_cod_especificacao_metodologia = table.Column<int>(type: "int", nullable: false),
                    uid_especificacao_metodologia_analise = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_especificacao_metodologia_analise", x => x.cod_especificacao_metodologia_analise)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_tb_especificacao_metodologia_analise_tb_certificado_analise_fk_cod_certificado_analise",
                        column: x => x.fk_cod_certificado_analise,
                        principalSchema: "dbo",
                        principalTable: "tb_certificado_analise",
                        principalColumn: "cod_certificado_analise",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_especificacao_metodologia_analise_tb_especificacao_metodologia_fk_cod_especificacao_metodologia",
                        column: x => x.fk_cod_especificacao_metodologia,
                        principalSchema: "dbo",
                        principalTable: "tb_especificacao_metodologia",
                        principalColumn: "cod_especificacao_metodologia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.Sql(@"
                 CREATE TRIGGER Trg_tb_certificado_analise_Insert
                 ON tb_certificado_analise
                 AFTER INSERT
                 AS
                 BEGIN
                     DECLARE @NovoId INT;
                     SET @NovoId = (SELECT cod_certificado_analise FROM inserted);

                     IF @NovoId < 100
	                 BEGIN
		                 UPDATE tb_certificado_analise
		                 SET des_numero = 'AGUA ' + RIGHT(REPLICATE('0', 2) + CAST(@NovoId AS VARCHAR), 2) + '/' + RIGHT(YEAR(GETDATE()), 2)
		                 WHERE cod_certificado_analise = @NovoId;
	                 END;

	                 IF @NovoId >= 100
	                 BEGIN
		                 UPDATE tb_certificado_analise
		                 SET des_numero = 'AGUA ' + CAST(@NovoId AS VARCHAR) + '/' + RIGHT(YEAR(GETDATE()), 2)
		                 WHERE cod_certificado_analise = @NovoId;
	                 END;
                 END;");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_aspecto_visual",
                columns: new[] { "cod_aspecto_visual", "des_especificacao", "des_resultado", "uid_aspecto_visual" },
                values: new object[] { 1, "Ausência de floração de algas ou outros organismos", "De acordo", new Guid("de63598c-b476-4178-99a6-64fecdeb3e1d") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_cliente",
                columns: new[] { "cod_cliente", "des_cnpj", "des_endereco", "des_razao_social", "uid_cliente" },
                values: new object[] { 1, "19.532.464/0001-77", "Avenida Cel. Antônio Augusto de Souza 49 - Cataguases - MG", "Clube do Remo", new Guid("d6b1697d-1a64-4572-9607-11ec3e4a028f") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_cloreto",
                columns: new[] { "cod_cloreto", "des_especificacao", "des_resultado", "uid_cloreto" },
                values: new object[] { 1, "Máximo 250 mg/L", "31,8 mg/L", new Guid("53283ffa-a07c-4f86-95b8-8f156e863455") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_cloro_residual_livre",
                columns: new[] { "cod_cloro_residual_livre", "des_especificacao", "des_resultado", "uid_cloro_residual_livre" },
                values: new object[] { 1, "Mínimo 1,0 mg/L", "4,2 mg/L", new Guid("377cfe56-45e4-48cd-ba02-c3df9fde66e9") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_coliforme_termotolerante",
                columns: new[] { "cod_coliforme_termotolerante", "des_especificacao", "des_resultado", "uid_coliforme_termotolerante" },
                values: new object[] { 1, "Máximo 2500 UFC/mL", "<1,0 x 10¹ UFC/mL est", new Guid("e8311341-6e20-45cd-8a0d-fcdbb7a664e2") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_cor_aparente",
                columns: new[] { "cod_cor_aparente", "des_especificacao", "des_resultado", "uid_cor_aparente" },
                values: new object[] { 1, "Máximo 75 uH", "0,0 uH", new Guid("202c2b11-9c6d-4140-9531-a5fa77952df4") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_especificacao_metodologia",
                columns: new[] { "cod_especificacao_metodologia", "des_especificacao_metodologia", "uid_especificacao_metodologia" },
                values: new object[,]
                {
                    { 1, "Resolução CONAMA nº 274 de 29 de novembro de 2000.", new Guid("c5390f05-abb7-4548-a406-47868039e345") },
                    { 2, "Standard Methods for the Examination of Water and Wastewater - American Public Health Association (APHA).", new Guid("d22fe98e-f477-469a-ad05-f847b44b0722") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_farmaceutico",
                columns: new[] { "cod_farmaceutico", "des_farmaceutico_especialidade", "des_farmaceutico_nome", "des_farmaceutico_registro_crq", "uid_farmaceutico" },
                values: new object[] { 1, "Farmacêutico Bioquímico", "José Carlos de Almeida Junior", "CRQ/MG 02419351", new Guid("53c5caa2-a8d4-492c-9d33-24cd0633957f") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_ferro",
                columns: new[] { "cod_ferro", "des_especificacao", "des_resultado", "uid_ferro" },
                values: new object[] { 1, "Máximo 0,3 mg/L", "0,0 mg/L", new Guid("345a0eec-3e25-4101-9bbf-71b09b9025b3") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_ph",
                columns: new[] { "cod_ph", "des_especificacao", "des_resultado", "uid_ph" },
                values: new object[] { 1, "0,6 a 0,9", "7,8", new Guid("6cba07c6-5e26-4d70-bc92-0d3858364966") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_solidos_totais_dissolvidos",
                columns: new[] { "cod_solidos_totais_dissolvidos", "des_especificacao", "des_resultado", "uid_solidos_totais_dissolvidos" },
                values: new object[] { 1, "Máximo 500 mg/L", "229,0 mg/L", new Guid("7bea91a4-bffc-4729-bea6-eda5d4646d6d") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_turbidez",
                columns: new[] { "cod_turbidez", "des_especificacao", "des_resultado", "uid_turbidez" },
                values: new object[] { 1, "Máximo 40 uT", "0,8 uT", new Guid("042d0fe0-02cf-408e-ac10-5e842995b752") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_certificado_analise",
                columns: new[] { "cod_certificado_analise", "des_amostra", "fk_cod_cliente", "data_hora_coleta", "data_hora_inicio_analise", "data_hora_recebimento_caseus", "data_hora_termino_analise", "fk_cod_farmaceutico_responsavel", "des_funcao_agua", "des_local_coleta", "des_parecer_farmaceutico", "des_responsavel_coleta", "uid_certificado_analise" },
                values: new object[] { 1, "Água de recreação", 1, new DateTime(2020, 2, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lazer", "Piscina Grande", "A amostra analisada atende às especificações descritas.", "Aparecida Amadeu", new Guid("02eb459d-c4b2-44ef-b2ad-b92964c4ec8f") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                columns: new[] { "cod_analise_fisico_quimica", "fk_cod_aspecto_visual", "fk_cod_certificado_analise", "fk_cod_cloreto", "fk_cod_cloreto_visual", "fk_cod_cor_aparente", "fk_cod_ferro", "fk_cod_ph", "fk_cod_solidos_totais_dissolvidos", "fk_cod_turbidez", "uid_analise_fisico_quimica" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, new Guid("1b3cb229-f008-40d7-8e19-34af0fa08bc5") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_analise_microbiologica",
                columns: new[] { "cod_analise_microbiologica", "fk_cod_certificado_analise", "fk_cod_coliforme_termotolerante", "uid_analise_microbiologica" },
                values: new object[] { 1, 1, 1, new Guid("cbc1daa2-176e-438b-95d5-9345711bb761") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tb_especificacao_metodologia_analise",
                columns: new[] { "cod_especificacao_metodologia_analise", "fk_cod_certificado_analise", "fk_cod_especificacao_metodologia", "uid_especificacao_metodologia_analise" },
                values: new object[,]
                {
                    { 1, 1, 1, new Guid("00f270ee-b3ce-4839-8ce1-1d86b7452827") },
                    { 2, 1, 2, new Guid("c639b772-fec2-4c09-81e9-0d13bc195560") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_aspecto_visual",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_aspecto_visual");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_certificado_analise",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_certificado_analise",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_cloreto",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_cloreto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_cloreto_visual",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_cloreto_visual");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_cor_aparente",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_cor_aparente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_ferro",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_ferro");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_ph",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_ph");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_solidos_totais_dissolvidos",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_solidos_totais_dissolvidos");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_fisico_quimica_fk_cod_turbidez",
                schema: "dbo",
                table: "tb_analise_fisico_quimica",
                column: "fk_cod_turbidez");

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_microbiologica_fk_cod_certificado_analise",
                schema: "dbo",
                table: "tb_analise_microbiologica",
                column: "fk_cod_certificado_analise",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_analise_microbiologica_fk_cod_coliforme_termotolerante",
                schema: "dbo",
                table: "tb_analise_microbiologica",
                column: "fk_cod_coliforme_termotolerante");

            migrationBuilder.CreateIndex(
                name: "IX_tb_certificado_analise_fk_cod_cliente",
                schema: "dbo",
                table: "tb_certificado_analise",
                column: "fk_cod_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_certificado_analise_fk_cod_farmaceutico_responsavel",
                schema: "dbo",
                table: "tb_certificado_analise",
                column: "fk_cod_farmaceutico_responsavel");

            migrationBuilder.CreateIndex(
                name: "IX_tb_especificacao_metodologia_analise_fk_cod_certificado_analise",
                schema: "dbo",
                table: "tb_especificacao_metodologia_analise",
                column: "fk_cod_certificado_analise");

            migrationBuilder.CreateIndex(
                name: "IX_tb_especificacao_metodologia_analise_fk_cod_especificacao_metodologia",
                schema: "dbo",
                table: "tb_especificacao_metodologia_analise",
                column: "fk_cod_especificacao_metodologia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_analise_fisico_quimica",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_analise_microbiologica",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_especificacao_metodologia_analise",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_aspecto_visual",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_cloreto",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_cloro_residual_livre",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_cor_aparente",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_ferro",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_ph",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_solidos_totais_dissolvidos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_turbidez",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_coliforme_termotolerante",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_certificado_analise",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_especificacao_metodologia",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_cliente",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tb_farmaceutico",
                schema: "dbo");
        }
    }
}
