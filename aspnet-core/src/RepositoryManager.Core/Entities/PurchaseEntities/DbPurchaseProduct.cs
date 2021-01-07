using Abp.Domain.Entities.Auditing;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.PurchaseEntities
{
    /// <summary>
    ///采购单
    /// </summary>
    [Table("PurchaseProduct")]
    public class DbPurchaseProduct : FullAuditedEntity
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string SerialNumber { private set; get; } = new Guid().ToString().Replace("-", "");

        /// <summary>
        /// 采购单产品的主键
        /// </summary>
        public int DbWarehouseProductId { set; get; }

        /// <summary>
        /// 采购单采购的产品
        /// </summary>
        public DbWarehouseProduct DbWarehouseProduct { set; get; }

        /// <summary>
        /// 采购产品入库的Id
        /// </summary>
        public int DbWarehouseId { set; get; }

        /// <summary>
        /// 采购产品入库的仓库
        /// </summary>
        public DbWarehouse DbWarehouse { set; get; }

    }
}
