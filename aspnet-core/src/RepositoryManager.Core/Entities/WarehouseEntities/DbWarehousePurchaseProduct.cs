using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 仓库进货表
    /// </summary>
    [Table("WarehousePurchaseProduct")]
    public class DbWarehousePurchaseProduct : AuditedEntity
    {
        /// <summary>
        /// 产品Id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 进货数量
        /// </summary>
        public long PurchaseCount { set; get; }

        /// <summary>
        /// 进货价格
        /// </summary>
        public decimal PurchasePrice { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remarks { set; get; }

    }
}
