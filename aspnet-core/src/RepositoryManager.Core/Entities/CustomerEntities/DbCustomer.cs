﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.CustomerEntities
{
    /// <summary>
    /// 客户表
    /// </summary>
    [Table("Customer")]
    public class DbCustomer : AuditedEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Column(TypeName = "varchar(30)")]
        public string Name { set; get; }

        /// <summary>
        /// 地址
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Adress { set; get; }

        /// <summary>
        /// 邮编
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string Postcode { set; get; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string PrincipalName { set; get; }

        /// <summary>
        /// 负责人联系方式
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public string PrincipalPhone { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Remarks { set; get; }
    }
}
