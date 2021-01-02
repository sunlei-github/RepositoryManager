using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    /// <summary>
    /// 仓库表
    /// </summary>
    [Table("Warehouse")]
    public class DbWarehouse : FullAuditedEntity
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string WarehouseName { set; get; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [Column(TypeName = "varchar(60)")]
        public string WarehouseAddress { set; get; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string PrincipalName { set; get; }

        /// <summary>
        /// 负责人联系方式
        /// </summary>
        [Column(TypeName = "varchar(11)")]
        public string PrincipalPhone { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remarks { set; get; }

    }
}
