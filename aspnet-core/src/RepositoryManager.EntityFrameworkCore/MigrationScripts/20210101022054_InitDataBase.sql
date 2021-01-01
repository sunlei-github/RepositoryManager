CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `AbpAuditLogs` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `TenantId` int NULL,
    `UserId` bigint NULL,
    `ServiceName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `MethodName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `Parameters` varchar(1024) CHARACTER SET utf8mb4 NULL,
    `ReturnValue` longtext CHARACTER SET utf8mb4 NULL,
    `ExecutionTime` datetime(6) NOT NULL,
    `ExecutionDuration` int NOT NULL,
    `ClientIpAddress` varchar(64) CHARACTER SET utf8mb4 NULL,
    `ClientName` varchar(128) CHARACTER SET utf8mb4 NULL,
    `BrowserInfo` varchar(512) CHARACTER SET utf8mb4 NULL,
    `Exception` varchar(2000) CHARACTER SET utf8mb4 NULL,
    `ImpersonatorUserId` bigint NULL,
    `ImpersonatorTenantId` int NULL,
    `CustomData` varchar(2000) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpAuditLogs` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpBackgroundJobs` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `JobType` varchar(512) CHARACTER SET utf8mb4 NOT NULL,
    `JobArgs` longtext CHARACTER SET utf8mb4 NOT NULL,
    `TryCount` smallint NOT NULL,
    `NextTryTime` datetime(6) NOT NULL,
    `LastTryTime` datetime(6) NULL,
    `IsAbandoned` tinyint(1) NOT NULL,
    `Priority` tinyint unsigned NOT NULL,
    CONSTRAINT `PK_AbpBackgroundJobs` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpDynamicProperties` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `PropertyName` varchar(255) CHARACTER SET utf8mb4 NULL,
    `InputType` longtext CHARACTER SET utf8mb4 NULL,
    `Permission` longtext CHARACTER SET utf8mb4 NULL,
    `TenantId` int NULL,
    CONSTRAINT `PK_AbpDynamicProperties` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpEditions` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `Name` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    `DisplayName` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AbpEditions` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpEntityChangeSets` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `BrowserInfo` varchar(512) CHARACTER SET utf8mb4 NULL,
    `ClientIpAddress` varchar(64) CHARACTER SET utf8mb4 NULL,
    `ClientName` varchar(128) CHARACTER SET utf8mb4 NULL,
    `CreationTime` datetime(6) NOT NULL,
    `ExtensionData` longtext CHARACTER SET utf8mb4 NULL,
    `ImpersonatorTenantId` int NULL,
    `ImpersonatorUserId` bigint NULL,
    `Reason` varchar(256) CHARACTER SET utf8mb4 NULL,
    `TenantId` int NULL,
    `UserId` bigint NULL,
    CONSTRAINT `PK_AbpEntityChangeSets` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpLanguages` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `TenantId` int NULL,
    `Name` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `DisplayName` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
    `Icon` varchar(128) CHARACTER SET utf8mb4 NULL,
    `IsDisabled` tinyint(1) NOT NULL,
    CONSTRAINT `PK_AbpLanguages` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpLanguageTexts` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `TenantId` int NULL,
    `LanguageName` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `Source` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `Key` varchar(256) CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AbpLanguageTexts` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpNotifications` (
    `Id` char(36) NOT NULL,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `NotificationName` varchar(96) CHARACTER SET utf8mb4 NOT NULL,
    `Data` longtext CHARACTER SET utf8mb4 NULL,
    `DataTypeName` varchar(512) CHARACTER SET utf8mb4 NULL,
    `EntityTypeName` varchar(250) CHARACTER SET utf8mb4 NULL,
    `EntityTypeAssemblyQualifiedName` varchar(512) CHARACTER SET utf8mb4 NULL,
    `EntityId` varchar(96) CHARACTER SET utf8mb4 NULL,
    `Severity` tinyint unsigned NOT NULL,
    `UserIds` longtext CHARACTER SET utf8mb4 NULL,
    `ExcludedUserIds` longtext CHARACTER SET utf8mb4 NULL,
    `TenantIds` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpNotifications` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpNotificationSubscriptions` (
    `Id` char(36) NOT NULL,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `NotificationName` varchar(96) CHARACTER SET utf8mb4 NULL,
    `EntityTypeName` varchar(250) CHARACTER SET utf8mb4 NULL,
    `EntityTypeAssemblyQualifiedName` varchar(512) CHARACTER SET utf8mb4 NULL,
    `EntityId` varchar(96) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpNotificationSubscriptions` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpOrganizationUnitRoles` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `RoleId` int NOT NULL,
    `OrganizationUnitId` bigint NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    CONSTRAINT `PK_AbpOrganizationUnitRoles` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpOrganizationUnits` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `TenantId` int NULL,
    `ParentId` bigint NULL,
    `Code` varchar(95) CHARACTER SET utf8mb4 NOT NULL,
    `DisplayName` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AbpOrganizationUnits` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId` FOREIGN KEY (`ParentId`) REFERENCES `AbpOrganizationUnits` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `AbpTenantNotifications` (
    `Id` char(36) NOT NULL,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `NotificationName` varchar(96) CHARACTER SET utf8mb4 NOT NULL,
    `Data` longtext CHARACTER SET utf8mb4 NULL,
    `DataTypeName` varchar(512) CHARACTER SET utf8mb4 NULL,
    `EntityTypeName` varchar(250) CHARACTER SET utf8mb4 NULL,
    `EntityTypeAssemblyQualifiedName` varchar(512) CHARACTER SET utf8mb4 NULL,
    `EntityId` varchar(96) CHARACTER SET utf8mb4 NULL,
    `Severity` tinyint unsigned NOT NULL,
    CONSTRAINT `PK_AbpTenantNotifications` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpUserAccounts` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `UserLinkId` bigint NULL,
    `UserName` varchar(256) CHARACTER SET utf8mb4 NULL,
    `EmailAddress` varchar(256) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpUserAccounts` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpUserLoginAttempts` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `TenantId` int NULL,
    `TenancyName` varchar(64) CHARACTER SET utf8mb4 NULL,
    `UserId` bigint NULL,
    `UserNameOrEmailAddress` varchar(256) CHARACTER SET utf8mb4 NULL,
    `ClientIpAddress` varchar(64) CHARACTER SET utf8mb4 NULL,
    `ClientName` varchar(128) CHARACTER SET utf8mb4 NULL,
    `BrowserInfo` varchar(512) CHARACTER SET utf8mb4 NULL,
    `Result` tinyint unsigned NOT NULL,
    `CreationTime` datetime(6) NOT NULL,
    CONSTRAINT `PK_AbpUserLoginAttempts` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpUserNotifications` (
    `Id` char(36) NOT NULL,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `TenantNotificationId` char(36) NOT NULL,
    `State` int NOT NULL,
    `CreationTime` datetime(6) NOT NULL,
    CONSTRAINT `PK_AbpUserNotifications` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpUserOrganizationUnits` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `OrganizationUnitId` bigint NOT NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    CONSTRAINT `PK_AbpUserOrganizationUnits` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpUsers` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `AuthenticationSource` varchar(64) CHARACTER SET utf8mb4 NULL,
    `UserName` varchar(256) CHARACTER SET utf8mb4 NOT NULL,
    `TenantId` int NULL,
    `EmailAddress` varchar(256) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
    `Surname` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
    `Password` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `EmailConfirmationCode` varchar(328) CHARACTER SET utf8mb4 NULL,
    `PasswordResetCode` varchar(328) CHARACTER SET utf8mb4 NULL,
    `LockoutEndDateUtc` datetime(6) NULL,
    `AccessFailedCount` int NOT NULL,
    `IsLockoutEnabled` tinyint(1) NOT NULL,
    `PhoneNumber` varchar(32) CHARACTER SET utf8mb4 NULL,
    `IsPhoneNumberConfirmed` tinyint(1) NOT NULL,
    `SecurityStamp` varchar(128) CHARACTER SET utf8mb4 NULL,
    `IsTwoFactorEnabled` tinyint(1) NOT NULL,
    `IsEmailConfirmed` tinyint(1) NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 NOT NULL,
    `NormalizedEmailAddress` varchar(256) CHARACTER SET utf8mb4 NOT NULL,
    `ConcurrencyStamp` varchar(128) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpUsers` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpUsers_AbpUsers_CreatorUserId` FOREIGN KEY (`CreatorUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AbpUsers_AbpUsers_DeleterUserId` FOREIGN KEY (`DeleterUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AbpUsers_AbpUsers_LastModifierUserId` FOREIGN KEY (`LastModifierUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `AbpWebhookEvents` (
    `Id` char(36) NOT NULL,
    `WebhookName` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Data` longtext CHARACTER SET utf8mb4 NULL,
    `CreationTime` datetime(6) NOT NULL,
    `TenantId` int NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeletionTime` datetime(6) NULL,
    CONSTRAINT `PK_AbpWebhookEvents` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpWebhookSubscriptions` (
    `Id` char(36) NOT NULL,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `WebhookUri` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Secret` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IsActive` tinyint(1) NOT NULL,
    `Webhooks` longtext CHARACTER SET utf8mb4 NULL,
    `Headers` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpWebhookSubscriptions` PRIMARY KEY (`Id`)
);

CREATE TABLE `AbpDynamicEntityProperties` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `EntityFullName` varchar(255) CHARACTER SET utf8mb4 NULL,
    `DynamicPropertyId` int NOT NULL,
    `TenantId` int NULL,
    CONSTRAINT `PK_AbpDynamicEntityProperties` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpDynamicEntityProperties_AbpDynamicProperties_DynamicPrope~` FOREIGN KEY (`DynamicPropertyId`) REFERENCES `AbpDynamicProperties` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpDynamicPropertyValues` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    `TenantId` int NULL,
    `DynamicPropertyId` int NOT NULL,
    CONSTRAINT `PK_AbpDynamicPropertyValues` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpDynamicPropertyValues_AbpDynamicProperties_DynamicPropert~` FOREIGN KEY (`DynamicPropertyId`) REFERENCES `AbpDynamicProperties` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpFeatures` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `Name` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `Value` varchar(2000) CHARACTER SET utf8mb4 NOT NULL,
    `Discriminator` longtext CHARACTER SET utf8mb4 NOT NULL,
    `EditionId` int NULL,
    CONSTRAINT `PK_AbpFeatures` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpFeatures_AbpEditions_EditionId` FOREIGN KEY (`EditionId`) REFERENCES `AbpEditions` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpEntityChanges` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `ChangeTime` datetime(6) NOT NULL,
    `ChangeType` tinyint unsigned NOT NULL,
    `EntityChangeSetId` bigint NOT NULL,
    `EntityId` varchar(48) CHARACTER SET utf8mb4 NULL,
    `EntityTypeFullName` varchar(192) CHARACTER SET utf8mb4 NULL,
    `TenantId` int NULL,
    CONSTRAINT `PK_AbpEntityChanges` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId` FOREIGN KEY (`EntityChangeSetId`) REFERENCES `AbpEntityChangeSets` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpRoles` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `TenantId` int NULL,
    `Name` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    `DisplayName` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
    `IsStatic` tinyint(1) NOT NULL,
    `IsDefault` tinyint(1) NOT NULL,
    `NormalizedName` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    `ConcurrencyStamp` varchar(128) CHARACTER SET utf8mb4 NULL,
    `Description` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpRoles` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpRoles_AbpUsers_CreatorUserId` FOREIGN KEY (`CreatorUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AbpRoles_AbpUsers_DeleterUserId` FOREIGN KEY (`DeleterUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AbpRoles_AbpUsers_LastModifierUserId` FOREIGN KEY (`LastModifierUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `AbpSettings` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `TenantId` int NULL,
    `UserId` bigint NULL,
    `Name` varchar(256) CHARACTER SET utf8mb4 NOT NULL,
    `Value` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpSettings` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpSettings_AbpUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `AbpTenants` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `LastModificationTime` datetime(6) NULL,
    `LastModifierUserId` bigint NULL,
    `IsDeleted` tinyint(1) NOT NULL,
    `DeleterUserId` bigint NULL,
    `DeletionTime` datetime(6) NULL,
    `TenancyName` varchar(64) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `ConnectionString` varchar(1024) CHARACTER SET utf8mb4 NULL,
    `IsActive` tinyint(1) NOT NULL,
    `EditionId` int NULL,
    CONSTRAINT `PK_AbpTenants` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpTenants_AbpUsers_CreatorUserId` FOREIGN KEY (`CreatorUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AbpTenants_AbpUsers_DeleterUserId` FOREIGN KEY (`DeleterUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AbpTenants_AbpEditions_EditionId` FOREIGN KEY (`EditionId`) REFERENCES `AbpEditions` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_AbpTenants_AbpUsers_LastModifierUserId` FOREIGN KEY (`LastModifierUserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `AbpUserClaims` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `ClaimType` varchar(256) CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpUserClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpUserClaims_AbpUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpUserLogins` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `LoginProvider` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `ProviderKey` varchar(256) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_AbpUserLogins` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpUserLogins_AbpUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpUserRoles` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `RoleId` int NOT NULL,
    CONSTRAINT `PK_AbpUserRoles` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpUserRoles_AbpUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpUserTokens` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `TenantId` int NULL,
    `UserId` bigint NOT NULL,
    `LoginProvider` varchar(128) CHARACTER SET utf8mb4 NULL,
    `Name` varchar(128) CHARACTER SET utf8mb4 NULL,
    `Value` varchar(512) CHARACTER SET utf8mb4 NULL,
    `ExpireDate` datetime(6) NULL,
    CONSTRAINT `PK_AbpUserTokens` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpUserTokens_AbpUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpWebhookSendAttempts` (
    `Id` char(36) NOT NULL,
    `WebhookEventId` char(36) NOT NULL,
    `WebhookSubscriptionId` char(36) NOT NULL,
    `Response` longtext CHARACTER SET utf8mb4 NULL,
    `ResponseStatusCode` int NULL,
    `CreationTime` datetime(6) NOT NULL,
    `LastModificationTime` datetime(6) NULL,
    `TenantId` int NULL,
    CONSTRAINT `PK_AbpWebhookSendAttempts` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpWebhookSendAttempts_AbpWebhookEvents_WebhookEventId` FOREIGN KEY (`WebhookEventId`) REFERENCES `AbpWebhookEvents` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpDynamicEntityPropertyValues` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Value` longtext CHARACTER SET utf8mb4 NOT NULL,
    `EntityId` longtext CHARACTER SET utf8mb4 NULL,
    `DynamicEntityPropertyId` int NOT NULL,
    `TenantId` int NULL,
    CONSTRAINT `PK_AbpDynamicEntityPropertyValues` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpDynamicEntityPropertyValues_AbpDynamicEntityProperties_Dy~` FOREIGN KEY (`DynamicEntityPropertyId`) REFERENCES `AbpDynamicEntityProperties` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpEntityPropertyChanges` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `EntityChangeId` bigint NOT NULL,
    `NewValue` varchar(512) CHARACTER SET utf8mb4 NULL,
    `OriginalValue` varchar(512) CHARACTER SET utf8mb4 NULL,
    `PropertyName` varchar(96) CHARACTER SET utf8mb4 NULL,
    `PropertyTypeFullName` varchar(192) CHARACTER SET utf8mb4 NULL,
    `TenantId` int NULL,
    CONSTRAINT `PK_AbpEntityPropertyChanges` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId` FOREIGN KEY (`EntityChangeId`) REFERENCES `AbpEntityChanges` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpPermissions` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `Name` varchar(128) CHARACTER SET utf8mb4 NOT NULL,
    `IsGranted` tinyint(1) NOT NULL,
    `Discriminator` longtext CHARACTER SET utf8mb4 NOT NULL,
    `RoleId` int NULL,
    `UserId` bigint NULL,
    CONSTRAINT `PK_AbpPermissions` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpPermissions_AbpRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AbpRoles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AbpPermissions_AbpUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AbpUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AbpRoleClaims` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `CreationTime` datetime(6) NOT NULL,
    `CreatorUserId` bigint NULL,
    `TenantId` int NULL,
    `RoleId` int NOT NULL,
    `ClaimType` varchar(256) CHARACTER SET utf8mb4 NULL,
    `ClaimValue` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_AbpRoleClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AbpRoleClaims_AbpRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AbpRoles` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_AbpAuditLogs_TenantId_ExecutionDuration` ON `AbpAuditLogs` (`TenantId`, `ExecutionDuration`);

CREATE INDEX `IX_AbpAuditLogs_TenantId_ExecutionTime` ON `AbpAuditLogs` (`TenantId`, `ExecutionTime`);

CREATE INDEX `IX_AbpAuditLogs_TenantId_UserId` ON `AbpAuditLogs` (`TenantId`, `UserId`);

CREATE INDEX `IX_AbpBackgroundJobs_IsAbandoned_NextTryTime` ON `AbpBackgroundJobs` (`IsAbandoned`, `NextTryTime`);

CREATE INDEX `IX_AbpDynamicEntityProperties_DynamicPropertyId` ON `AbpDynamicEntityProperties` (`DynamicPropertyId`);

CREATE UNIQUE INDEX `IX_AbpDynamicEntityProperties_EntityFullName_DynamicPropertyId_~` ON `AbpDynamicEntityProperties` (`EntityFullName`, `DynamicPropertyId`, `TenantId`);

CREATE INDEX `IX_AbpDynamicEntityPropertyValues_DynamicEntityPropertyId` ON `AbpDynamicEntityPropertyValues` (`DynamicEntityPropertyId`);

CREATE UNIQUE INDEX `IX_AbpDynamicProperties_PropertyName_TenantId` ON `AbpDynamicProperties` (`PropertyName`, `TenantId`);

CREATE INDEX `IX_AbpDynamicPropertyValues_DynamicPropertyId` ON `AbpDynamicPropertyValues` (`DynamicPropertyId`);

CREATE INDEX `IX_AbpEntityChanges_EntityChangeSetId` ON `AbpEntityChanges` (`EntityChangeSetId`);

CREATE INDEX `IX_AbpEntityChanges_EntityTypeFullName_EntityId` ON `AbpEntityChanges` (`EntityTypeFullName`, `EntityId`);

CREATE INDEX `IX_AbpEntityChangeSets_TenantId_CreationTime` ON `AbpEntityChangeSets` (`TenantId`, `CreationTime`);

CREATE INDEX `IX_AbpEntityChangeSets_TenantId_Reason` ON `AbpEntityChangeSets` (`TenantId`, `Reason`);

CREATE INDEX `IX_AbpEntityChangeSets_TenantId_UserId` ON `AbpEntityChangeSets` (`TenantId`, `UserId`);

CREATE INDEX `IX_AbpEntityPropertyChanges_EntityChangeId` ON `AbpEntityPropertyChanges` (`EntityChangeId`);

CREATE INDEX `IX_AbpFeatures_EditionId_Name` ON `AbpFeatures` (`EditionId`, `Name`);

CREATE INDEX `IX_AbpFeatures_TenantId_Name` ON `AbpFeatures` (`TenantId`, `Name`);

CREATE INDEX `IX_AbpLanguages_TenantId_Name` ON `AbpLanguages` (`TenantId`, `Name`);

CREATE INDEX `IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key` ON `AbpLanguageTexts` (`TenantId`, `Source`, `LanguageName`, `Key`);

CREATE INDEX `IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName~` ON `AbpNotificationSubscriptions` (`NotificationName`, `EntityTypeName`, `EntityId`, `UserId`);

CREATE INDEX `IX_AbpNotificationSubscriptions_TenantId_NotificationName_Entit~` ON `AbpNotificationSubscriptions` (`TenantId`, `NotificationName`, `EntityTypeName`, `EntityId`, `UserId`);

CREATE INDEX `IX_AbpOrganizationUnitRoles_TenantId_OrganizationUnitId` ON `AbpOrganizationUnitRoles` (`TenantId`, `OrganizationUnitId`);

CREATE INDEX `IX_AbpOrganizationUnitRoles_TenantId_RoleId` ON `AbpOrganizationUnitRoles` (`TenantId`, `RoleId`);

CREATE INDEX `IX_AbpOrganizationUnits_ParentId` ON `AbpOrganizationUnits` (`ParentId`);

CREATE INDEX `IX_AbpOrganizationUnits_TenantId_Code` ON `AbpOrganizationUnits` (`TenantId`, `Code`);

CREATE INDEX `IX_AbpPermissions_TenantId_Name` ON `AbpPermissions` (`TenantId`, `Name`);

CREATE INDEX `IX_AbpPermissions_RoleId` ON `AbpPermissions` (`RoleId`);

CREATE INDEX `IX_AbpPermissions_UserId` ON `AbpPermissions` (`UserId`);

CREATE INDEX `IX_AbpRoleClaims_RoleId` ON `AbpRoleClaims` (`RoleId`);

CREATE INDEX `IX_AbpRoleClaims_TenantId_ClaimType` ON `AbpRoleClaims` (`TenantId`, `ClaimType`);

CREATE INDEX `IX_AbpRoles_CreatorUserId` ON `AbpRoles` (`CreatorUserId`);

CREATE INDEX `IX_AbpRoles_DeleterUserId` ON `AbpRoles` (`DeleterUserId`);

CREATE INDEX `IX_AbpRoles_LastModifierUserId` ON `AbpRoles` (`LastModifierUserId`);

CREATE INDEX `IX_AbpRoles_TenantId_NormalizedName` ON `AbpRoles` (`TenantId`, `NormalizedName`);

CREATE INDEX `IX_AbpSettings_UserId` ON `AbpSettings` (`UserId`);

CREATE UNIQUE INDEX `IX_AbpSettings_TenantId_Name_UserId` ON `AbpSettings` (`TenantId`, `Name`, `UserId`);

CREATE INDEX `IX_AbpTenantNotifications_TenantId` ON `AbpTenantNotifications` (`TenantId`);

CREATE INDEX `IX_AbpTenants_CreatorUserId` ON `AbpTenants` (`CreatorUserId`);

CREATE INDEX `IX_AbpTenants_DeleterUserId` ON `AbpTenants` (`DeleterUserId`);

CREATE INDEX `IX_AbpTenants_EditionId` ON `AbpTenants` (`EditionId`);

CREATE INDEX `IX_AbpTenants_LastModifierUserId` ON `AbpTenants` (`LastModifierUserId`);

CREATE INDEX `IX_AbpTenants_TenancyName` ON `AbpTenants` (`TenancyName`);

CREATE INDEX `IX_AbpUserAccounts_EmailAddress` ON `AbpUserAccounts` (`EmailAddress`);

CREATE INDEX `IX_AbpUserAccounts_UserName` ON `AbpUserAccounts` (`UserName`);

CREATE INDEX `IX_AbpUserAccounts_TenantId_EmailAddress` ON `AbpUserAccounts` (`TenantId`, `EmailAddress`);

CREATE INDEX `IX_AbpUserAccounts_TenantId_UserId` ON `AbpUserAccounts` (`TenantId`, `UserId`);

CREATE INDEX `IX_AbpUserAccounts_TenantId_UserName` ON `AbpUserAccounts` (`TenantId`, `UserName`);

CREATE INDEX `IX_AbpUserClaims_UserId` ON `AbpUserClaims` (`UserId`);

CREATE INDEX `IX_AbpUserClaims_TenantId_ClaimType` ON `AbpUserClaims` (`TenantId`, `ClaimType`);

CREATE INDEX `IX_AbpUserLoginAttempts_UserId_TenantId` ON `AbpUserLoginAttempts` (`UserId`, `TenantId`);

CREATE INDEX `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Resu~` ON `AbpUserLoginAttempts` (`TenancyName`, `UserNameOrEmailAddress`, `Result`);

CREATE INDEX `IX_AbpUserLogins_UserId` ON `AbpUserLogins` (`UserId`);

CREATE INDEX `IX_AbpUserLogins_TenantId_UserId` ON `AbpUserLogins` (`TenantId`, `UserId`);

CREATE INDEX `IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey` ON `AbpUserLogins` (`TenantId`, `LoginProvider`, `ProviderKey`);

CREATE INDEX `IX_AbpUserNotifications_UserId_State_CreationTime` ON `AbpUserNotifications` (`UserId`, `State`, `CreationTime`);

CREATE INDEX `IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId` ON `AbpUserOrganizationUnits` (`TenantId`, `OrganizationUnitId`);

CREATE INDEX `IX_AbpUserOrganizationUnits_TenantId_UserId` ON `AbpUserOrganizationUnits` (`TenantId`, `UserId`);

CREATE INDEX `IX_AbpUserRoles_UserId` ON `AbpUserRoles` (`UserId`);

CREATE INDEX `IX_AbpUserRoles_TenantId_RoleId` ON `AbpUserRoles` (`TenantId`, `RoleId`);

CREATE INDEX `IX_AbpUserRoles_TenantId_UserId` ON `AbpUserRoles` (`TenantId`, `UserId`);

CREATE INDEX `IX_AbpUsers_CreatorUserId` ON `AbpUsers` (`CreatorUserId`);

CREATE INDEX `IX_AbpUsers_DeleterUserId` ON `AbpUsers` (`DeleterUserId`);

CREATE INDEX `IX_AbpUsers_LastModifierUserId` ON `AbpUsers` (`LastModifierUserId`);

CREATE INDEX `IX_AbpUsers_TenantId_NormalizedEmailAddress` ON `AbpUsers` (`TenantId`, `NormalizedEmailAddress`);

CREATE INDEX `IX_AbpUsers_TenantId_NormalizedUserName` ON `AbpUsers` (`TenantId`, `NormalizedUserName`);

CREATE INDEX `IX_AbpUserTokens_UserId` ON `AbpUserTokens` (`UserId`);

CREATE INDEX `IX_AbpUserTokens_TenantId_UserId` ON `AbpUserTokens` (`TenantId`, `UserId`);

CREATE INDEX `IX_AbpWebhookSendAttempts_WebhookEventId` ON `AbpWebhookSendAttempts` (`WebhookEventId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210101022054_InitDataBase', '3.1.8');

