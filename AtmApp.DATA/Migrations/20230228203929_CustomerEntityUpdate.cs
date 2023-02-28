using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtmApp.DATA.Migrations
{
    public partial class CustomerEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Customer",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Customer",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Middlename",
                table: "Customer",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customer",
                type: "nvarchar(15)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Middlename",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customer",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
