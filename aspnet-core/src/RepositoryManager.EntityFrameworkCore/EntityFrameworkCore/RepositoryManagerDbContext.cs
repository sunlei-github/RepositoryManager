using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RepositoryManager.Authorization.Roles;
using RepositoryManager.Authorization.Users;
using RepositoryManager.MultiTenancy;
using RepositoryManager.Entities.WarehouseEntities;
using RepositoryManager.Entities.SupplierEntites;
using RepositoryManager.Entities.CustomerEntities;

namespace RepositoryManager.EntityFrameworkCore
{
    public class RepositoryManagerDbContext : AbpZeroDbContext<Tenant, Role, User, RepositoryManagerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RepositoryManagerDbContext(DbContextOptions<RepositoryManagerDbContext> options)
            : base(options)
        {
        }

        #region 与仓库相关的表
        public DbSet<DbWarehouse> DbWarehouseTables { set; get; }

        public DbSet<DbWarehouseIntoProduct> DbWarehouseIntoProducts { set; get; }

        public DbSet<DbWarehouseInventory> DbWarehouseInventories { set; get; }

        public DbSet<DbWarehouseOutProduct> DbWarehouseOutProducts { set; get; }

        public DbSet<DbWarehouseProduct> DbWarehouseProducts { set; get; }

        public DbSet<DbWarehouseProductType> DbWarehouseProductTypes { set; get; }

        public DbSet<DbWarehousePurchaseProduct> DbWarehousePurchaseProducts { set; get; }

        public DbSet<DbWarehouseRefunProduct> DbWarehouseRefunProducts { set; get; }
        #endregion

        #region 供应商相关的表

        public DbSet<DbSupplier> DbSuppliers { set; get; }

        #endregion

        #region 客户相关的表

        public DbSet<DbCustomer> DbCustomers { set; get; }

        #endregion
    }
}
