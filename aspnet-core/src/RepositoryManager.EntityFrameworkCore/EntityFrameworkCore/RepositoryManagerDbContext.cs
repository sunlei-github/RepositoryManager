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

        public DbSet<DbWarehouseIntoProductRecord> DbWarehouseIntoProducts { set; get; }

        public DbSet<DbWarehouseOutProductRecord> DbWarehouseOutProducts { set; get; }

        public DbSet<DbWarehouseProduct> DbWarehouseProducts { set; get; }

        public DbSet<DbWarehouseProductType> DbWarehouseProductTypes { set; get; }

        public DbSet<DbWarehouseRefunProduct> DbWarehouseRefunProducts { set; get; }

        #endregion

        #region 供应商相关的表

        public DbSet<DbSupplier> DbSuppliers { set; get; }

        public DbSet<DbSupplierSale> DbSupplierSales { set; get; }

        #endregion

        #region 客户相关的表

        public DbSet<DbCustomer> DbCustomers { set; get; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 设置主键
            //复合主键
            modelBuilder.Entity<DbSupplierDbSupplierSale>().HasKey(c => new { c.DbSupplierId, c.DbSupplierSellId });
            modelBuilder.Entity<DbWarehouseDbProduct>().HasKey(c => new { c.DbWarehouseId, c.DbWarehouseProductId });
            #endregion

            #region 表关系
            modelBuilder.Entity<DbSupplierDbSupplierSale>().HasOne(c => c.DbSupplierSell)
                .WithMany(c => c.DbSupplierDbSupplierSales).HasForeignKey(c => c.DbSupplierSellId);
            modelBuilder.Entity<DbSupplierDbSupplierSale>().HasOne(c => c.DbSupplier)
                .WithMany(c => c.DbSupplierDbSupplierSells).HasForeignKey(c => c.DbSupplierId);

            modelBuilder.Entity<DbWarehouseDbProduct>().HasOne(c => c.DbWarehouse)
                .WithMany(c => c.DbWarehouseDbProducts).HasForeignKey(c => c.DbWarehouseId);
            modelBuilder.Entity<DbWarehouseDbProduct>().HasOne(c => c.DbWarehouseProduct)
                .WithMany(c => c.DbWarehouseDbProducts).HasForeignKey(c => c.DbWarehouseProductId);

            modelBuilder.Entity<DbWarehouseProduct>().HasOne(c => c.DbWarehouseProductType)
                .WithOne().HasForeignKey<DbWarehouseProduct>(c => c.ProductType);
            #endregion

            #region 设置索引
            modelBuilder.Entity<DbWarehouse>().HasIndex(c => c.WarehouseName);
            modelBuilder.Entity<DbWarehouseIntoProductRecord>().HasIndex(c => c.CreationTime);
            modelBuilder.Entity<DbWarehouseOutProductRecord>().HasIndex(c => c.CreationTime);
            modelBuilder.Entity<DbWarehouseProduct>().HasIndex(c => c.Name);
            modelBuilder.Entity<DbWarehouseRefunProduct>().HasIndex(c => c.CreationTime);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
