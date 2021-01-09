using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RepositoryManager.Common.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json.Converters;

namespace RepositoryManager.Entities.PurchaseEntities
{
    /// <summary>
    /// 入库审核表日志表
    /// </summary>
    [Table("PurchaseProductAuditRecord")]
    public class DbPurchaseProductAuditRecord : Entity, ICreationAudited, IHasCreationTime
    {
        /// <summary>
        /// 一级审核人的姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string FirstAuditorName { set; get; }

        /// <summary>
        /// 一级审核结果
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AuditResultEnum FirstAuditResult { set; get; }

        /// <summary>
        /// 一级审核完成时间
        /// </summary>
        public DateTime? FirstAuditTime { set; get; }

        /// <summary>
        /// 二级审核人的姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string SecondAuditorName { set; get; }

        /// <summary>
        /// 二级审核结果
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AuditResultEnum SecondAuditResult { set; get; }

        /// <summary>
        /// 二级审核完成时间
        /// </summary>
        public DateTime? SecondAuditTime { set; get; }

        /// <summary>
        /// 三级审核人的姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string ThridAuditorName { set; get; }

        /// <summary>
        /// 三级审核结果
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AuditResultEnum ThridAuditResult { set; get; }

        /// <summary>
        /// 三级审核完成时间
        /// </summary>
        public DateTime? ThridAuditTime { set; get; }

        /// <summary>
        /// 审核的备注
        /// </summary>
        [Column(TypeName = "varchar(1000)")]
        public string Remarks { set; get; }

        /// <summary>
        /// 发起时间
        /// </summary>
        public DateTime CreationTime { set; get; }

        /// <summary>
        /// 发起人
        /// </summary>
        public long? CreatorUserId { set; get; }
    }
}
