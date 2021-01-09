using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.SupplierEntites
{
    /// <summary>
    /// 供应商销售表
    /// </summary>
    [Table("SupplierSale")]
    public class DbSupplierSale : Entity
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string SerialNumber { private set; get; } = new Guid().ToString().Replace("-", "");

        /// <summary>
        /// 仓库名称
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string WarehouseName { set; get; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [Column(TypeName = "varchar(60)")]
        public string WarehouseAdress { set; get; }

        /// <summary>
        /// 货物名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string ProductName { set; get; }

        /// <summary>
        /// 卖出货物数量
        /// </summary>
        public long ProductCount { set; get; }

        /// <summary>
        /// 卖出货物单价
        /// </summary>
        public decimal ProductPirce { set; get; }

        /// <summary>
        /// 卖出负责人姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string SellPrincipalName { set; get; }

        /// <summary>
        /// 卖出负责人联系方式
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string PrincipalPhone { set; get; }

        /// <summary>
        /// 卖出时间
        /// </summary>
        public DateTime SellTime { set; get; }

        /// <summary>
        /// 买入负责人姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string BuyPrincipalName { set; get; }

        /// <summary>
        /// 买入负责人联系方式
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string BuyPrincipalPhone { set; get; }

        /// <summary>
        /// 多对多中间表  供应商表
        /// </summary>
        public ICollection<DbSupplierDbSupplierSale> DbSupplierDbSupplierSales { set; get; }

    }
}
