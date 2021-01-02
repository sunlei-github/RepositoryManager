using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 货物表
    /// </summary>
    [Table("WarehouseProduct")]
    public class DbWarehouseProduct : FullAuditedEntity
    {
        /// <summary>
        /// 产品类型
        /// </summary>
        public int ProductType { set; get; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [NotMapped]
        public DbWarehouseProductType DbWarehouseProductType { set; get; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public int WarehouseId { set; get; }

        /// <summary>
        /// 产品数量
        /// </summary>
        public long Count { set; get; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { set; get; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Name { set; get; }
    }
}
