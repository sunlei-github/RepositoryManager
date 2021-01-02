using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 产品入库表
    /// </summary>
    [Table("WarehouseIntoProduct")]
    public class DbWarehouseIntoProduct : AuditedEntity
    {
        /// <summary>
        /// 仓库ID
        /// </summary>
        public int WarehouseId { set; get; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 入库数量
        /// </summary>
        public long WarehousingCount { set; get; }

        /// <summary>
        /// 入库价格
        /// </summary>
        public decimal WarehousingPrice { set; get; }

    }
}
