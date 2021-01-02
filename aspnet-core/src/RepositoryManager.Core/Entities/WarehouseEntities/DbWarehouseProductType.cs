using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 仓库产品类型表
    /// </summary>
    [Table("WarehouseProductType")]
    public class DbWarehouseProductType: FullAuditedEntity
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string Name { set; get; }

        /// <summary>
        /// 父级类型的Id   采用树型结构  如果是最顶级的类型父级Id为空
        /// </summary>
        public int? ParentId { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remarks { set; get; }
    }
}
