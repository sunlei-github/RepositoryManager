using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryManager.Migrations
{
    public partial class AlterTablesAddIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_WarehouseRefunProduct_CreationTime",
                table: "WarehouseRefunProduct",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousePurchaseProduct_CreationTime",
                table: "WarehousePurchaseProduct",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseProduct_Name",
                table: "WarehouseProduct",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseOutProduct_CreationTime",
                table: "WarehouseOutProduct",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseIntoProduct_CreationTime",
                table: "WarehouseIntoProduct",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_WarehouseName",
                table: "Warehouse",
                column: "WarehouseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WarehouseRefunProduct_CreationTime",
                table: "WarehouseRefunProduct");

            migrationBuilder.DropIndex(
                name: "IX_WarehousePurchaseProduct_CreationTime",
                table: "WarehousePurchaseProduct");

            migrationBuilder.DropIndex(
                name: "IX_WarehouseProduct_Name",
                table: "WarehouseProduct");

            migrationBuilder.DropIndex(
                name: "IX_WarehouseOutProduct_CreationTime",
                table: "WarehouseOutProduct");

            migrationBuilder.DropIndex(
                name: "IX_WarehouseIntoProduct_CreationTime",
                table: "WarehouseIntoProduct");

            migrationBuilder.DropIndex(
                name: "IX_Warehouse_WarehouseName",
                table: "Warehouse");
        }
    }
}
