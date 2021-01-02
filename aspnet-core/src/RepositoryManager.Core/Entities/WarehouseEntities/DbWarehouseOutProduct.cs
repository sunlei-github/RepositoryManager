using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 仓库出库明细表
    /// </summary>
    [Table("WarehouseOutProduct")]
    public class DbWarehouseOutProduct : AuditedEntity
    {
        /// <summary>
        /// 产品Id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 出库数量
        /// </summary>
        public long StockOutCount { set; get; }

        /// <summary>
        /// 出库价格
        /// </summary>
        public decimal StockOutPrice { set; get; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public int WarehouseId { set; get; }
    }
}
