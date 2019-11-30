using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoDeFrota.Infra.Migrations
{
    public partial class Update_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Extensao",
                table: "Imagens",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Combustiveis",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 8, "Diesel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Combustiveis",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Extensao",
                table: "Imagens",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
