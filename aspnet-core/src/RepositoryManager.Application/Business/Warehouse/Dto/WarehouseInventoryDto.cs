using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.Dto
{
    [AutoMap(typeof(DbWarehouseInventory))]
   public class WarehouseInventoryDto : EntityDto
    {

        /// <summary>
        /// 仓库Id
        /// </summary>
        public int WarehouseId { set; get; }

        /// <summary>
        /// 产品Id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 剩余数量
        /// </summary>
        public long Balance { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { set; get; }
    }

    /// <summary>
    /// 新增仓库库存的Dto
    /// </summary>
    public class CreateWarehouseInventoryInput : WarehouseInventoryDto
    { }

    /// <summary>
    /// 编辑仓库库存的Dto
    /// </summary>
    public class EditWarehouseInventoryInput : WarehouseInventoryDto
    { }

    /// <summary>
    /// 删除仓库库存的Dto
    /// </summary>
    public class DeleteWarehouseInventoryInput : EntityDto
    { }

    /// <summary>
    /// 输入ID查询查询整个仓库库存
    /// </summary>
    public class SearchWarehouseInventoryInput : EntityDto
    { }

    /// <summary>
    /// 根据输入的ID返回整个仓库库存的信息
    /// </summary>
    public class SearchWarehouseInventoryOutput : WarehouseInventoryDto
    { }

}
