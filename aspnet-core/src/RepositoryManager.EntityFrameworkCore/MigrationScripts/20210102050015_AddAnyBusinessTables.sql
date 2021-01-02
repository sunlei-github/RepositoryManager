CREATE TABLE `Customer` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `Name` varchar(30) NULL,
    `Adress` varchar(50) NULL,
    `Postcode` varchar(20) NULL,
    `PrincipalName` varchar(20) NULL,
    `PrincipalPhone` varchar(20) NULL,
    `Remarks` varchar(100) NULL,
    CONSTRAINT `PK_Customer` PRIMARY KEY (`Id`)
);

CREATE TABLE `Supplier` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `Name` varchar(30) NULL,
    `Adress` varchar(50) NULL,
    `Postcode` varchar(20) NULL,
    `PrincipalName` varchar(20) NULL,
    `PrincipalPhone` varchar(20) NULL,
    `Remarks` varchar(100) NULL,
    CONSTRAINT `PK_Supplier` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseIntoProduct` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `WarehouseId` int NOT NULL,
    `ProductId` int NOT NULL,
    `WarehousingCount` bigint NOT NULL,
    `WarehousingPrice` decimal(65,30) NOT NULL,
    CONSTRAINT `PK_WarehouseIntoProduct` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseInventory` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `WarehouseId` int NOT NULL,
    `ProductId` int NOT NULL,
    `Balance` bigint NOT NULL,
    `Remarks` varchar(100) NULL,
    CONSTRAINT `PK_WarehouseInventory` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseOutProduct` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `ProductId` int NOT NULL,
    `StockOutCount` bigint NOT NULL,
    `StockOutPrice` decimal(65,30) NOT NULL,
    `WarehouseId` int NOT NULL,
    CONSTRAINT `PK_WarehouseOutProduct` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseProduct` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `ProductType` int NOT NULL,
    `WarehouseId` int NOT NULL,
    `Count` bigint NOT NULL,
    `Price` decimal(65,30) NOT NULL,
    `Name` varchar(50) NULL,
    CONSTRAINT `PK_WarehouseProduct` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseProductType` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `Name` varchar(30) NULL,
    `ParentId` int NULL,
    `Remarks` varchar(100) NULL,
    CONSTRAINT `PK_WarehouseProductType` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehousePurchaseProduct` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `ProductId` int NOT NULL,
    `PurchaseCount` bigint NOT NULL,
    `PurchasePrice` decimal(65,30) NOT NULL,
    `Remarks` varchar(100) NULL,
    CONSTRAINT `PK_WarehousePurchaseProduct` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseRefunProduct` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `ProductId` int NOT NULL,
    `RefunCount` bigint NOT NULL,
    `RefunPrice` decimal(65,30) NOT NULL,
    `RefundReason` varchar(100) NULL,
    CONSTRAINT `PK_WarehouseRefunProduct` PRIMARY KEY (`Id`)
);

CREATE TABLE `WarehouseTable` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `WarehouseName` varchar(30) NULL,
    `WarehouseAddress` varchar(60) NULL,
    `PrincipalName` varchar(20) NULL,
    `PrincipalPhone` varchar(11) NULL,
    `Remarks` varchar(100) NULL,
    CONSTRAINT `PK_WarehouseTable` PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210102050015_AddAnyBusinessTables', '3.1.8');

