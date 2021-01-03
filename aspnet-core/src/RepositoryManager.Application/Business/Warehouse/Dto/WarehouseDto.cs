using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.Dto
{
    [AutoMap(typeof(DbWarehouse))]
    public class WarehouseDto: EntityDto
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WarehouseName { set; get; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        public string WarehouseAddress { set; get; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        public string PrincipalName { set; get; }

        /// <summary>
        /// 负责人联系方式
        /// </summary>
        public string PrincipalPhone { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { set; get; }

    }

    /// <summary>
    /// 输入ID查询单个仓库信息
    /// </summary>
    public class SearchWarehouseInput : EntityDto
    { }
    
    /// <summary>
    /// 根据输入ID输出整个仓库基本信息
    /// </summary>
    public class SearchWarehouseOutput : WarehouseDto
    { }

    /// <summary>
    /// 分页查询的输入  PagedAndSortedResultRequestDto 可排序
    /// </summary>
    public class SearchWarehousesInput : PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WarehouseName { set; get; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        public string WarehouseAddress { set; get; }
    }

    /// <summary>
    /// 分页返回的Dto
    /// </summary>
    public class SearchWarehousesOutput : PagedResultDto<WarehouseDto>
    { }    

    /// <summary>
    /// 创建仓库的Dto
    /// </summary>
    public class CreateWarehouseInput : WarehouseDto
    { }

    /// <summary>
    /// 删除仓库的ID
    /// </summary>
    public class DeleteWarehouseInput : EntityDto
    { }

    /// <summary>
    /// 修改仓库的Dto
    /// </summary>
    public class EditWarehouseInput : WarehouseDto
    { }
}
