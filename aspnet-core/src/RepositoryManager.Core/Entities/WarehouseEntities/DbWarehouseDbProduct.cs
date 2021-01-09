using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryManager.Entities.WarehouseEntities
{
    [Table("RelationWarehouseProduct")]
    public class DbWarehouseDbProduct 
    {
        public int DbWarehouseId { set; get; }

        public DbWarehouse DbWarehouse { set; get; }

        public int DbWarehouseProductId { set; get; }

        public DbWarehouseProduct DbWarehouseProduct { set; get; }
    }
}
