using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.SupplierEntites
{

    /// <summary>
    /// 供应商和供应商销售表 多对多中间表
    /// </summary>
    [Table("RelationSupplierSupplierSale")]
    public class DbSupplierDbSupplierSale 
    {
        public int DbSupplierId { set; get; }

        public DbSupplier DbSupplier { set; get; }

        public int DbSupplierSellId { set; get; }

        public DbSupplierSale DbSupplierSell { set; get; }
    }
}
