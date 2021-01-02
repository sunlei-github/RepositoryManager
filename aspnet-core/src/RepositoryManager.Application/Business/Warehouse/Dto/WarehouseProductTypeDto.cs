using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.Dto
{
    [AutoMapTo(typeof(DbWarehouseProductType))]
    public class WarehouseProductTypeDto : EntityDto
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 父级类型的Id   
        /// </summary>
        public int? ParentId { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { set; get; }
    }

    /// <summary>
    /// 创建货物类型
    /// </summary>
    public class CreateWarehouseProductType : WarehouseProductTypeDto
    { }

    /// <summary>
    /// 编辑货物类型
    /// </summary>
    public class EditWarehouseProductType : WarehouseProductTypeDto
    { }

    /// <summary>
    /// 删除货物类型
    /// </summary>
    public class DeleteWarehouseProductType : EntityDto
    { }
}
