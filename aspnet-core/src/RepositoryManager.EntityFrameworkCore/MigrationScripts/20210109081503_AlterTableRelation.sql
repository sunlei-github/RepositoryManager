DROP TABLE `WarehouseIntoProduct`;

DROP TABLE `WarehouseInventory`;

DROP TABLE `WarehouseOutProduct`;

DROP TABLE `WarehousePurchaseProduct`;

ALTER TABLE `WarehouseProduct` DROP COLUMN `WarehouseId`;

CREATE TABLE `RelationWarehouseProduct` (
    `DbWarehouseId` int NOT NULL,
    `DbWarehouseProductId` int NOT NULL,
    CONSTRAINT `PK_RelationWarehouseProduct` PRIMARY KEY (`DbWarehouseId`, `DbWarehouseProductId`),
    CONSTRAINT `FK_RelationWarehouseProduct_Warehouse_DbWarehouseId` FOREIGN KEY (`DbWarehouseId`) REFERENCES `Warehouse` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_RelationWarehouseProduct_WarehouseProduct_DbWarehouseProduct~` FOREIGN KEY (`DbWarehouseProductId`) REFERENCES `WarehouseProduct` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SupplierSale` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `SerialNumber` longtext CHARACTER SET utf8mb4 NULL,
    `WarehouseName` varchar(30) NULL,
    `WarehouseAdress` varchar(60) NULL,
    `ProductName` varchar(50) NULL,
    `ProductCount` bigint NOT NULL,
    `ProductPirce` decimal(65,30) NOT NULL,
    `SellPrincipalName` varchar(20) NULL,
    `PrincipalPhone` varchar(11) NULL,
    `SellTime` datetime(6) NOT NULL,
    `BuyPrincipalName` varchar(20) NULL,
    `BuyPrincipalPhone` varchar(11) NULL,
    CONSTRAINT `PK_SupplierSale` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseIntoProductRecord` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `ProductName` varchar(50) NULL,
    `DbWareHouseName` varchar(30) NULL,
    `WarehousingCount` bigint NOT NULL,
    `WarehousingPrice` decimal(65,30) NOT NULL,
    `EnterWarehousetApproach` int NOT NULL,
    CONSTRAINT `PK_WarehouseIntoProductRecord` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseOutProductRecord` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `ProductName` varchar(50) NULL,
    `StockOutCount` bigint NOT NULL,
    `StockOutPrice` decimal(65,30) NOT NULL,
    `DbWareHouseName` varchar(30) NULL,
    `OutWarehousetApproach` int NOT NULL,
    CONSTRAINT `PK_WarehouseOutProductRecord` PRIMARY KEY (`Id`)
);

CREATE TABLE `RelationSupplierSupplierSale` (
    `DbSupplierId` int NOT NULL,
    `DbSupplierSellId` int NOT NULL,
    CONSTRAINT `PK_RelationSupplierSupplierSale` PRIMARY KEY (`DbSupplierId`, `DbSupplierSellId`),
    CONSTRAINT `FK_RelationSupplierSupplierSale_Supplier_DbSupplierId` FOREIGN KEY (`DbSupplierId`) REFERENCES `Supplier` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_RelationSupplierSupplierSale_SupplierSale_DbSupplierSellId` FOREIGN KEY (`DbSupplierSellId`) REFERENCES `SupplierSale` (`Id`) ON DELETE CASCADE
);

CREATE UNIQUE INDEX `IX_WarehouseProduct_ProductType` ON `WarehouseProduct` (`ProductType`);

CREATE INDEX `IX_RelationSupplierSupplierSale_DbSupplierSellId` ON `RelationSupplierSupplierSale` (`DbSupplierSellId`);

CREATE INDEX `IX_RelationWarehouseProduct_DbWarehouseProductId` ON `RelationWarehouseProduct` (`DbWarehouseProductId`);

CREATE INDEX `IX_WarehouseIntoProductRecord_CreationTime` ON `WarehouseIntoProductRecord` (`CreationTime`);

CREATE INDEX `IX_WarehouseOutProductRecord_CreationTime` ON `WarehouseOutProductRecord` (`CreationTime`);

ALTER TABLE `WarehouseProduct` ADD CONSTRAINT `FK_WarehouseProduct_WarehouseProductType_ProductType` FOREIGN KEY (`ProductType`) REFERENCES `WarehouseProductType` (`Id`) ON DELETE CASCADE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210109081503_AlterTableRelation', '3.1.8');

