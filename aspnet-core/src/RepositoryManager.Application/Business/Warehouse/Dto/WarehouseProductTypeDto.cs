using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Newtonsoft.Json;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.Dto
{
    [AutoMap(typeof(DbWarehouseProductType))]
    public class WarehouseProductTypeDto : EntityDto
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 父级类型的Id   采用树型结构  如果是最顶级的类型父级Id为空
        /// 该属性不需要返回给前端
        /// </summary>
        [JsonIgnore]
        public int? ParentId { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { set; get; }
    }

    /// <summary>
    /// 创建货物类型
    /// </summary>
    public class CreateWarehouseProductTypeInput : WarehouseProductTypeDto
    { }

    /// <summary>
    /// 编辑货物类型
    /// </summary>
    public class EditWarehouseProductTypeInput : WarehouseProductTypeDto
    { }

    /// <summary>
    /// 删除货物类型
    /// </summary>
    public class DeleteWarehouseProductTypeInput : EntityDto
    { }

    /// <summary>
    /// 父级仓库类型里面的子级仓库类型集合
    /// </summary>
    public class WarehouseProductTypesDto : WarehouseProductTypeDto
    {
        public List<WarehouseProductTypesDto> WarehouseProductTypeDtos { set; get; }
    }

    /// <summary>
    /// 输出仓库的数据结构
    /// </summary>
    public class WarehouseProductTypesOutput
    {
        public List<WarehouseProductTypesDto> WarehouseProductTypes { set; get; }
    }
}
