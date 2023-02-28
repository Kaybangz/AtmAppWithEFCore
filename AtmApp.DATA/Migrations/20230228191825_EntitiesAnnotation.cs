using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtmApp.DATA.Migrations
{
    public partial class EntitiesAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Customers_CustomerId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Customers_ReceiverId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Customers_SenderId",
                table: "Transfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Transfers",
                newName: "Transfer");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Transfer",
                newName: "TransferId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_SenderId",
                table: "Transfer",
                newName: "IX_Transfer_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_ReceiverId",
                table: "Transfer",
                newName: "IX_Transfer_ReceiverId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Transaction",
                newName: "TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CustomerId",
                table: "Transaction",
                newName: "IX_Transaction_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Pin",
                table: "Customer",
                newName: "int(5)");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customer",
                newName: "nvarchar(50)");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "Customer",
                type: "nvarchar(15)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transfer",
                table: "Transfer",
                column: "TransferId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "TransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerId",
                table: "Transaction",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Customer_ReceiverId",
                table: "Transfer",
                column: "ReceiverId",
                principalTable: "Customer",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfer_Customer_SenderId",
                table: "Transfer",
                column: "SenderId",
                principalTable: "Customer",
                principalColumn: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Customer_ReceiverId",
                table: "Transfer");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfer_Customer_SenderId",
                table: "Transfer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transfer",
                table: "Transfer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Transfer",
                newName: "Transfers");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "TransferId",
                table: "Transfers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_SenderId",
                table: "Transfers",
                newName: "IX_Transfers_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfer_ReceiverId",
                table: "Transfers",
                newName: "IX_Transfers_ReceiverId");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Transactions",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_CustomerId",
                table: "Transactions",
                newName: "IX_Transactions_CustomerId");

            migrationBuilder.RenameColumn(
                name: "nvarchar(50)",
                table: "Customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "int(5)",
                table: "Customers",
                newName: "Pin");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "AccountNumber",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Customers_CustomerId",
                table: "Transactions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Customers_ReceiverId",
                table: "Transfers",
                column: "ReceiverId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Customers_SenderId",
                table: "Transfers",
                column: "SenderId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
