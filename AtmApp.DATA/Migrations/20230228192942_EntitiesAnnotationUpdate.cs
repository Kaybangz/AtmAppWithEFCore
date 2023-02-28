using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtmApp.DATA.Migrations
{
    public partial class EntitiesAnnotationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(50)",
                table: "Customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "int(5)",
                table: "Customer",
                newName: "Pin");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customer",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pin",
                table: "Customer",
                newName: "int(5)");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customer",
                newName: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50)",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }
    }
}
