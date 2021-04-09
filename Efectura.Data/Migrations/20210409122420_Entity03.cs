using Microsoft.EntityFrameworkCore.Migrations;

namespace Efectura.Data.Migrations
{
    public partial class Entity03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TCKN",
                table: "Consumers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TCKN",
                table: "Consumers",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
