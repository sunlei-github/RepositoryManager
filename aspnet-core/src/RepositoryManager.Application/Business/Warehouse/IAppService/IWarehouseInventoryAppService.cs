using Abp.Application.Services;
using RepositoryManager.Business.Warehouse.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.IAppService
{
   public interface IWarehouseInventoryAppService : IApplicationService
    {

        /// <summary>
        /// 创建新增仓库库存
        /// </summary>
        /// <param name="input"></param>
        void CreateWarehouseInventory(CreateWarehouseInventoryInput input);

        /// <summary>
        /// 编辑修改仓库库存
        /// </summary>
        /// <param name="input"></param>
        void EditWarehouseInventory(EditWarehouseInventoryInput input);

        /// <summary>
        /// 删除仓库库存
        /// </summary>
        /// <param name="input"></param>
        void DeleteWarehouseInventory(DeleteWarehouseInventoryInput input);

        /// <summary>
        /// 查询仓库库存
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        SearchWarehouseInventoryOutput SearchWarehouseInventory(SearchWarehouseInventoryInput input);

    }
}
