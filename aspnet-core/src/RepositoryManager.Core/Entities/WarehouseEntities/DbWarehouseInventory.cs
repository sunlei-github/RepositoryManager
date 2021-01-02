using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 仓库库存表
    /// </summary>
    [Table("WarehouseInventory")]
    public class DbWarehouseInventory : Entity
    {
        /// <summary>
        /// 仓库Id
        /// </summary>
        public int WarehouseId { set; get; }

        /// <summary>
        /// 产品Id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 剩余数量
        /// </summary>
        public long Balance { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remarks { set; get; }
    }
}
