using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using RepositoryManager.Entities.WarehouseEntities;
using Abp.AutoMapper;

namespace RepositoryManager.Business.Warehouse.Dto
{
    /// <summary>
    /// 产品Dto
    /// </summary>
    [AutoMapTo(typeof(DbWarehouseProduct))]
    public class WarehouseProductDto : EntityDto
    {
        /// <summary>
        /// 产品类型
        /// </summary>
        public int ProductType { set; get; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public int WarehouseId { set; get; }

        /// <summary>
        /// 产品数量
        /// </summary>
        public long Count { set; get; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { set; get; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { set; get; }
    }

    /// <summary>
    /// 创建产品的Dto
    /// </summary>
    public class CreateWarehouseProductInput : WarehouseProductDto
    { }

    /// <summary>
    /// 编辑产品的Dto
    /// </summary>
    public class EditWarehouseProductInput : WarehouseProductDto
    { }

    /// <summary>
    /// 删除产品的Id
    /// </summary>
    public class DeleteWarehouseProductInput : EntityDto
    { }
}
