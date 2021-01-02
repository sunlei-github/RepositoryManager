using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 仓库退货表
    /// </summary>
    [Table("WarehouseRefunProduct")]
    public class DbWarehouseRefunProduct : AuditedEntity
    {
        /// <summary>
        /// 产品Id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 退货数量
        /// </summary>
        public long RefunCount { set; get; }

        /// <summary>
        /// 退货价格
        /// </summary>
        public decimal RefunPrice { set; get; }

        /// <summary>
        /// 退货原因
        /// </summary>
        [Column(TypeName ="varchar(100)")]
        public string RefundReason { set; get; }
    }
}
