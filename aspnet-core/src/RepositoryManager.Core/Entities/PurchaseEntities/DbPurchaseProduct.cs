using Abp.Domain.Entities.Auditing;
using Newtonsoft.Json.Converters;
using RepositoryManager.Common.Enum;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

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
        /// 货物名称
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string ProducetName { set; get; }

        /// <summary>
        /// 采购数量
        /// </summary>
        public long PurchaseCount { set; get; }

        /// <summary>
        /// 审核结果
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AuditResultEnum AuditResult { set; get; }

        /// <summary>
        /// 存放的仓库Id  用作外键 关联仓库
        /// </summary>
        public int DbWarehouseProductId { set; get; }

        /// <summary>
        /// 存放的仓库实体
        /// </summary>
        public DbWarehouseProduct DbWarehouseProduct { set; get; }


    }
}
