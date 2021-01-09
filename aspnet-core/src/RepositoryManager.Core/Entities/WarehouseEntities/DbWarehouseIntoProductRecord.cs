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
    /// 产品入库记录表
    /// </summary>
    [Table("WarehouseIntoProductRecord")]
    public class DbWarehouseIntoProductRecord : AuditedEntity
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string ProductName { set; get; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string DbWareHouseName { set; get; }

        /// <summary>
        /// 入库数量
        /// </summary>
        public long WarehousingCount { set; get; }

        /// <summary>
        /// 入库价格
        /// </summary>
        public decimal WarehousingPrice { set; get; }

        /// <summary>
        /// 入库途径
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public EnterWarehousetApproachEnum EnterWarehousetApproach { set; get; }

    }
}
