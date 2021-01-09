using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Newtonsoft.Json.Converters;
using RepositoryManager.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 仓库出库明细表
    /// </summary>
    [Table("WarehouseOutProductRecord")]
    public class DbWarehouseOutProductRecord : AuditedEntity
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string ProductName { set; get; }

        /// <summary>
        /// 出库数量
        /// </summary>
        public long StockOutCount { set; get; }

        /// <summary>
        /// 出库价格
        /// </summary>
        public decimal StockOutPrice { set; get; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string DbWareHouseName { set; get; }

        /// <summary>
        /// 出库途径
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public OutWarehousetApproachEnum OutWarehousetApproach { set; get; }
    }
}
