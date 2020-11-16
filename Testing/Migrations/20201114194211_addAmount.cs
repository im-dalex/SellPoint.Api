using Microsoft.EntityFrameworkCore.Migrations;

namespace Testing.Migrations
{
    public partial class addAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Product_BillId",
                table: "BillDetail");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "BillDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_ProductId",
                table: "BillDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Product_ProductId",
                table: "BillDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Product_ProductId",
                table: "BillDetail");

            migrationBuilder.DropIndex(
                name: "IX_BillDetail_ProductId",
                table: "BillDetail");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "BillDetail");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Product_BillId",
                table: "BillDetail",
                column: "BillId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
