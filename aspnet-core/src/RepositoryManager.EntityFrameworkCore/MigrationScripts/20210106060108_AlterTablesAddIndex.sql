CREATE INDEX `IX_WarehouseRefunProduct_CreationTime` ON `WarehouseRefunProduct` (`CreationTime`);

CREATE INDEX `IX_WarehousePurchaseProduct_CreationTime` ON `WarehousePurchaseProduct` (`CreationTime`);

CREATE INDEX `IX_WarehouseProduct_Name` ON `WarehouseProduct` (`Name`);

CREATE INDEX `IX_WarehouseOutProduct_CreationTime` ON `WarehouseOutProduct` (`CreationTime`);

CREATE INDEX `IX_WarehouseIntoProduct_CreationTime` ON `WarehouseIntoProduct` (`CreationTime`);

CREATE INDEX `IX_Warehouse_WarehouseName` ON `Warehouse` (`WarehouseName`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210106060108_AlterTablesAddIndex', '3.1.8');

