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
    [Table("PurchaseProductAuditRecord")]
    public class DbPurchaseProductAuditRecord : Entity, ICreationAudited, IHasCreationTime
    {
        /// <summary>
        /// 审核人的姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string AuditorName { set; get; }

        /// <summary>
        /// 审核的备注
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remarks { set; get; }

        /// <summary>
        /// 审核结果
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AuditResultEnum AuditResult { set; get; }

        /// <summary>
        /// 审核人Id
        /// </summary>
        public long? CreatorUserId { set; get; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime CreationTime { set; get; }
    }
}
