using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoDeFrota.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cambios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cambios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Classificacao = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Combustiveis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustiveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fabricantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Motorizacao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Origens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Procedencia = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quilometragem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Atual = table.Column<float>(maxLength: 6, nullable: false),
                    Anterior = table.Column<float>(maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quilometragem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    FabricanteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelos_Fabricantes_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(maxLength: 8, nullable: false),
                    Portas = table.Column<int>(nullable: false),
                    Tanque = table.Column<int>(nullable: false),
                    Chassi = table.Column<string>(maxLength: 17, nullable: false),
                    Potencia = table.Column<string>(nullable: false),
                    Lugares = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(maxLength: 8, nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    OrigemId = table.Column<int>(nullable: false),
                    ClasseId = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    CambioId = table.Column<int>(nullable: false),
                    CombustivelId = table.Column<int>(nullable: false),
                    ModeloId = table.Column<int>(nullable: false),
                    MotorId = table.Column<int>(nullable: false),
                    Quilometragem = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculos_Cambios_CambioId",
                        column: x => x.CambioId,
                        principalTable: "Cambios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculos_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculos_Combustiveis_CombustivelId",
                        column: x => x.CombustivelId,
                        principalTable: "Combustiveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculos_Modelos_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculos_Motores_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculos_Origens_OrigemId",
                        column: x => x.OrigemId,
                        principalTable: "Origens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Arquivo = table.Column<string>(maxLength: 50, nullable: true),
                    Diretorio = table.Column<string>(maxLength: 150, nullable: true),
                    Extensao = table.Column<string>(maxLength: 4, nullable: true),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagens_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cambios",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 1, "Manual" },
                    { 2, "Automático" },
                    { 3, "Automatizado" },
                    { 4, "Dualogic" },
                    { 5, "CVT" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 7, "Caminhoneta" },
                    { 6, "Jet Sky" },
                    { 5, "Lancha" },
                    { 8, "Micro-ônibus" },
                    { 3, "Ônibus" },
                    { 2, "Moto" },
                    { 1, "Carro" },
                    { 4, "Carreta" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Classificacao" },
                values: new object[,]
                {
                    { 10, "Médio" },
                    { 9, "Leve" },
                    { 8, "Pesado" },
                    { 7, "Hatch" },
                    { 6, "Off Road" },
                    { 5, "Sedan" },
                    { 3, "Esportivo" },
                    { 2, "Passeio" },
                    { 1, "Utilitário" },
                    { 4, "SUV" }
                });

            migrationBuilder.InsertData(
                table: "Combustiveis",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 5, "Gasolina Pódium" },
                    { 7, "Flex" },
                    { 4, "Gasolina Aditivada" },
                    { 6, "GNV" },
                    { 2, "Álcool Aditivado" },
                    { 3, "Gasolina Comum" },
                    { 1, "Álcool" }
                });

            migrationBuilder.InsertData(
                table: "Fabricantes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 5, "Toyota" },
                    { 4, "Honda" },
                    { 6, "Ford" },
                    { 2, "Chevrolet" },
                    { 1, "Fiat" },
                    { 3, "Volkswagem" }
                });

            migrationBuilder.InsertData(
                table: "Motores",
                columns: new[] { "Id", "Motorizacao" },
                values: new object[,]
                {
                    { 12, "1600 Cilindardas" },
                    { 18, "3100 Cilindardas" },
                    { 17, "2800 Cilindardas" },
                    { 16, "2400 Cilindardas" },
                    { 15, "2200 Cilindardas" },
                    { 14, "2000 Cilindardas" },
                    { 19, "4100 Cilindardas" },
                    { 13, "1700 Cilindardas" },
                    { 11, "1500 Cilindardas" },
                    { 6, "750 Cilindardas" },
                    { 9, "1300 Cilindardas" },
                    { 8, "1000 Cilindardas" },
                    { 7, "900 Cilindardas" },
                    { 5, "600 Cilindardas" },
                    { 4, "500 Cilindardas" },
                    { 3, "300 Cilindardas" },
                    { 2, "250 Cilindradas" },
                    { 1, "125 Cilindradas" },
                    { 10, "1400 Cilindardas" }
                });

            migrationBuilder.InsertData(
                table: "Origens",
                columns: new[] { "Id", "Procedencia" },
                values: new object[,]
                {
                    { 1, "Importado" },
                    { 2, "Nacional" }
                });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "FabricanteId", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "Palio" },
                    { 17, 6, "Edge" },
                    { 16, 6, "Ka" },
                    { 15, 6, "Fiesta" },
                    { 14, 6, "Focus" },
                    { 13, 5, "Corola" },
                    { 12, 5, "Etios" },
                    { 11, 4, "Civic" },
                    { 18, 6, "Fusion" },
                    { 10, 4, "Fit" },
                    { 8, 3, "Polo" },
                    { 7, 3, "Gol" },
                    { 6, 2, "Onix" },
                    { 5, 2, "Captiva" },
                    { 4, 2, "Cruze" },
                    { 3, 1, "Cronos" },
                    { 2, 1, "Argo" },
                    { 9, 3, "Virtus" },
                    { 19, 6, "Ranger" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_VeiculoId",
                table: "Imagens",
                column: "VeiculoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_FabricanteId",
                table: "Modelos",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_CambioId",
                table: "Veiculos",
                column: "CambioId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_CategoriaId",
                table: "Veiculos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ClasseId",
                table: "Veiculos",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_CombustivelId",
                table: "Veiculos",
                column: "CombustivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ModeloId",
                table: "Veiculos",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MotorId",
                table: "Veiculos",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_OrigemId",
                table: "Veiculos",
                column: "OrigemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropTable(
                name: "Quilometragem");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Cambios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Combustiveis");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Motores");

            migrationBuilder.DropTable(
                name: "Origens");

            migrationBuilder.DropTable(
                name: "Fabricantes");
        }
    }
}
