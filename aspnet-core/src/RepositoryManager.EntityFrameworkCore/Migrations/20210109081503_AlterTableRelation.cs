using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryManager.Migrations
{
    public partial class AlterTableRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarehouseIntoProduct");

            migrationBuilder.DropTable(
                name: "WarehouseInventory");

            migrationBuilder.DropTable(
                name: "WarehouseOutProduct");

            migrationBuilder.DropTable(
                name: "WarehousePurchaseProduct");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "WarehouseProduct");

            migrationBuilder.CreateTable(
                name: "RelationWarehouseProduct",
                columns: table => new
                {
                    DbWarehouseId = table.Column<int>(nullable: false),
                    DbWarehouseProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationWarehouseProduct", x => new { x.DbWarehouseId, x.DbWarehouseProductId });
                    table.ForeignKey(
                        name: "FK_RelationWarehouseProduct_Warehouse_DbWarehouseId",
                        column: x => x.DbWarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelationWarehouseProduct_WarehouseProduct_DbWarehouseProduct~",
                        column: x => x.DbWarehouseProductId,
                        principalTable: "WarehouseProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierSale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SerialNumber = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(type: "varchar(30)", nullable: true),
                    WarehouseAdress = table.Column<string>(type: "varchar(60)", nullable: true),
                    ProductName = table.Column<string>(type: "varchar(50)", nullable: true),
                    ProductCount = table.Column<long>(nullable: false),
                    ProductPirce = table.Column<decimal>(nullable: false),
                    SellPrincipalName = table.Column<string>(type: "varchar(20)", nullable: true),
                    PrincipalPhone = table.Column<string>(type: "varchar(11)", nullable: true),
                    SellTime = table.Column<DateTime>(nullable: false),
                    BuyPrincipalName = table.Column<string>(type: "varchar(20)", nullable: true),
                    BuyPrincipalPhone = table.Column<string>(type: "varchar(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierSale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseIntoProductRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ProductName = table.Column<string>(type: "varchar(50)", nullable: true),
                    DbWareHouseName = table.Column<string>(type: "varchar(30)", nullable: true),
                    WarehousingCount = table.Column<long>(nullable: false),
                    WarehousingPrice = table.Column<decimal>(nullable: false),
                    EnterWarehousetApproach = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseIntoProductRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseOutProductRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ProductName = table.Column<string>(type: "varchar(50)", nullable: true),
                    StockOutCount = table.Column<long>(nullable: false),
                    StockOutPrice = table.Column<decimal>(nullable: false),
                    DbWareHouseName = table.Column<string>(type: "varchar(30)", nullable: true),
                    OutWarehousetApproach = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseOutProductRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationSupplierSupplierSale",
                columns: table => new
                {
                    DbSupplierId = table.Column<int>(nullable: false),
                    DbSupplierSellId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationSupplierSupplierSale", x => new { x.DbSupplierId, x.DbSupplierSellId });
                    table.ForeignKey(
                        name: "FK_RelationSupplierSupplierSale_Supplier_DbSupplierId",
                        column: x => x.DbSupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelationSupplierSupplierSale_SupplierSale_DbSupplierSellId",
                        column: x => x.DbSupplierSellId,
                        principalTable: "SupplierSale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseProduct_ProductType",
                table: "WarehouseProduct",
                column: "ProductType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RelationSupplierSupplierSale_DbSupplierSellId",
                table: "RelationSupplierSupplierSale",
                column: "DbSupplierSellId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationWarehouseProduct_DbWarehouseProductId",
                table: "RelationWarehouseProduct",
                column: "DbWarehouseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseIntoProductRecord_CreationTime",
                table: "WarehouseIntoProductRecord",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseOutProductRecord_CreationTime",
                table: "WarehouseOutProductRecord",
                column: "CreationTime");

            migrationBuilder.AddForeignKey(
                name: "FK_WarehouseProduct_WarehouseProductType_ProductType",
                table: "WarehouseProduct",
                column: "ProductType",
                principalTable: "WarehouseProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WarehouseProduct_WarehouseProductType_ProductType",
                table: "WarehouseProduct");

            migrationBuilder.DropTable(
                name: "RelationSupplierSupplierSale");

            migrationBuilder.DropTable(
                name: "RelationWarehouseProduct");

            migrationBuilder.DropTable(
                name: "WarehouseIntoProductRecord");

            migrationBuilder.DropTable(
                name: "WarehouseOutProductRecord");

            migrationBuilder.DropTable(
                name: "SupplierSale");

            migrationBuilder.DropIndex(
                name: "IX_WarehouseProduct_ProductType",
                table: "WarehouseProduct");

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "WarehouseProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WarehouseIntoProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    WarehousingCount = table.Column<long>(type: "bigint", nullable: false),
                    WarehousingPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseIntoProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Balance = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(100)", nullable: true),
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseInventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseOutProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StockOutCount = table.Column<long>(type: "bigint", nullable: false),
                    StockOutPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseOutProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePurchaseProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PurchaseCount = table.Column<long>(type: "bigint", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePurchaseProduct", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseIntoProduct_CreationTime",
                table: "WarehouseIntoProduct",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseOutProduct_CreationTime",
                table: "WarehouseOutProduct",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousePurchaseProduct_CreationTime",
                table: "WarehousePurchaseProduct",
                column: "CreationTime");
        }
    }
}
