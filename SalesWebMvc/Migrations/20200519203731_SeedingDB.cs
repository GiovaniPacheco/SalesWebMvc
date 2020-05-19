using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class SeedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRec_Seller_SellerId",
                table: "SalesRec");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRec",
                table: "SalesRec");

            migrationBuilder.RenameTable(
                name: "SalesRec",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRec_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SalesRec");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRec",
                newName: "IX_SalesRec_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRec",
                table: "SalesRec",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRec_Seller_SellerId",
                table: "SalesRec",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
