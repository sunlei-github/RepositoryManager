using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.Dto
{
    [AutoMap(typeof(DbWarehouseIntoProductRecord))]
    public class WarehouseIntoProductDto : EntityDto
    {
        /// <summary>
        /// 仓库ID
        /// </summary>
        public int WarehouseId { set; get; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 入库数量
        /// </summary>
        public long WarehousingCount { set; get; }

        /// <summary>
        /// 入库价格
        /// </summary>
        public decimal WarehousingPrice { set; get; }

    }

    /// <summary>
    /// 仓库入库的Dto
    /// </summary>
    public class CreateWarehouseIntoProduct : WarehouseIntoProductDto
    { }

    /// <summary>
    /// 输入ID查询入库信息
    /// </summary>
    public class SearchWarehouseIntoProductInput : EntityDto
    { }

    /// <summary>
    /// 根据输入的ID输出入库所有信息
    /// </summary>
    public class SearchWarehouseIntoProductOutput : WarehouseIntoProductDto
    { }
}
