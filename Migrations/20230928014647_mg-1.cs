using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnsaioApp.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Ensaio",
                columns: table => new
                {
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ensaio", x => x.EnsaioId);
                    table.ForeignKey(
                        name: "FK_Ensaio_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnsaioDeCurtoCircuito",
                columns: table => new
                {
                    EnsaioDeCurtoCircuitoId = table.Column<int>(type: "int", nullable: false),
                    CorrenteDeCurtoCircuitoA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensaoDeCurtoCircuitoV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PotenciaDeCurtoCircuito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemperaturaAmbienteC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnsaioDeCurtoCircuito", x => x.EnsaioDeCurtoCircuitoId);
                    table.ForeignKey(
                        name: "FK_EnsaioDeCurtoCircuito_Ensaio_EnsaioDeCurtoCircuitoId",
                        column: x => x.EnsaioDeCurtoCircuitoId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnsaioEmVazio",
                columns: table => new
                {
                    EnsaioEmVazioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TensaoPreEnsaioV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrenteDeExcitacaoA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrenteDeExcitacaoPercentual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerdasEmVazioW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnsaioEmVazio", x => x.EnsaioEmVazioId);
                    table.ForeignKey(
                        name: "FK_EnsaioEmVazio_Ensaio_EnsaioId",
                        column: x => x.EnsaioId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelacaoDeTransformacao",
                columns: table => new
                {
                    RelacaoDeTransformacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fase1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fase2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fase3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentualErro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacaoDeTransformacao", x => x.RelacaoDeTransformacaoId);
                    table.ForeignKey(
                        name: "FK_RelacaoDeTransformacao_Ensaio_EnsaioId",
                        column: x => x.EnsaioId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResistenciaIsolamento",
                columns: table => new
                {
                    ResistenciaIsolamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeituraAtBt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeituraAtMassa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeituraBtMassa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensaoDoMegometro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResistenciaIsolamento", x => x.ResistenciaIsolamentoId);
                    table.ForeignKey(
                        name: "FK_ResistenciaIsolamento_Ensaio_EnsaioId",
                        column: x => x.EnsaioId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResistenciaOhmicaEnrolamentos",
                columns: table => new
                {
                    ResistenciaOhmicaEnrolamentosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    H1h2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    H1H3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    H2H3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnrolTs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemperaturaAmbiente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    X1x2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    X1x3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    X2x3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnrolTi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResistenciaOhmicaEnrolamentos", x => x.ResistenciaOhmicaEnrolamentosId);
                    table.ForeignKey(
                        name: "FK_ResistenciaOhmicaEnrolamentos_Ensaio_EnsaioId",
                        column: x => x.EnsaioId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rotina",
                columns: table => new
                {
                    RotinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Potencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ligacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Frequencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensaoAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensaoBt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Derivacoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtLigadaEmKv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtLigadaEmKv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrentAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrentBt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFabricacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MassaKg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotina", x => x.RotinaId);
                    table.ForeignKey(
                        name: "FK_Rotina_Ensaio_EnsaioId",
                        column: x => x.EnsaioId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TensaoAplicada",
                columns: table => new
                {
                    TensaoAplicadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtBtMassaKv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtAMassaKv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrequenciaHz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoDeEnsaio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TensaoAplicada", x => x.TensaoAplicadaId);
                    table.ForeignKey(
                        name: "FK_TensaoAplicada_Ensaio_EnsaioId",
                        column: x => x.EnsaioId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TensaoInduzida",
                columns: table => new
                {
                    TensaoInduzidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TensaoInduzidaV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrequenciaHz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoDeEnsaio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetodoDeEnsaio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TensaoInduzida", x => x.TensaoInduzidaId);
                    table.ForeignKey(
                        name: "FK_TensaoInduzida_Ensaio_EnsaioId",
                        column: x => x.EnsaioId,
                        principalTable: "Ensaio",
                        principalColumn: "EnsaioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ensaio_ClienteId",
                table: "Ensaio",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_EnsaioEmVazio_EnsaioId",
                table: "EnsaioEmVazio",
                column: "EnsaioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelacaoDeTransformacao_EnsaioId",
                table: "RelacaoDeTransformacao",
                column: "EnsaioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResistenciaIsolamento_EnsaioId",
                table: "ResistenciaIsolamento",
                column: "EnsaioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResistenciaOhmicaEnrolamentos_EnsaioId",
                table: "ResistenciaOhmicaEnrolamentos",
                column: "EnsaioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rotina_EnsaioId",
                table: "Rotina",
                column: "EnsaioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TensaoAplicada_EnsaioId",
                table: "TensaoAplicada",
                column: "EnsaioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TensaoInduzida_EnsaioId",
                table: "TensaoInduzida",
                column: "EnsaioId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnsaioDeCurtoCircuito");

            migrationBuilder.DropTable(
                name: "EnsaioEmVazio");

            migrationBuilder.DropTable(
                name: "RelacaoDeTransformacao");

            migrationBuilder.DropTable(
                name: "ResistenciaIsolamento");

            migrationBuilder.DropTable(
                name: "ResistenciaOhmicaEnrolamentos");

            migrationBuilder.DropTable(
                name: "Rotina");

            migrationBuilder.DropTable(
                name: "TensaoAplicada");

            migrationBuilder.DropTable(
                name: "TensaoInduzida");

            migrationBuilder.DropTable(
                name: "Ensaio");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
