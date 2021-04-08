using Microsoft.EntityFrameworkCore.Migrations;

namespace Efectura.Data.Migrations
{
    public partial class Entity02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "IsEnable",
                table: "Consumers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Consumers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnable",
                table: "Consumers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
