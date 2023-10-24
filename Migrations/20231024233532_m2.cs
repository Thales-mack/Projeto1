using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnsaioApp.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnsaioDeCurtoCircuito");

            migrationBuilder.DropTable(
                name: "EnsaioEmVazio");

            migrationBuilder.DropTable(
                name: "RelacaoDeTransformacao");

            migrationBuilder.DropTable(
                name: "TensaoAplicada");

            migrationBuilder.DropTable(
                name: "TensaoInduzida");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnsaioDeCurtoCircuito",
                columns: table => new
                {
                    EnsaioDeCurtoCircuitoId = table.Column<int>(type: "int", nullable: false),
                    CorrenteDeCurtoCircuitoA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsaioId = table.Column<int>(type: "int", nullable: false),
                    PotenciaDeCurtoCircuito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemperaturaAmbienteC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensaoDeCurtoCircuitoV = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    EnsaioId = table.Column<int>(type: "int", nullable: false),
                    CorrenteDeExcitacaoA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrenteDeExcitacaoPercentual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerdasEmVazioW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensaoPreEnsaioV = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    EnsaioId = table.Column<int>(type: "int", nullable: false),
                    Fase1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fase2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fase3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentualErro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tap = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "TensaoAplicada",
                columns: table => new
                {
                    TensaoAplicadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnsaioId = table.Column<int>(type: "int", nullable: false),
                    AtBtMassaKv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtAMassaKv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrequenciaHz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoDeEnsaio = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    EnsaioId = table.Column<int>(type: "int", nullable: false),
                    FrequenciaHz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetodoDeEnsaio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoDeEnsaio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TensaoInduzidaV = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
