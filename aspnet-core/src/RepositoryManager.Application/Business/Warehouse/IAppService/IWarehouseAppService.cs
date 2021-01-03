using Abp.Application.Services;
using RepositoryManager.Business.Warehouse.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.IAppService
{
    /// <summary>
    /// 仓库服务
    /// </summary>
    public interface IWarehouseAppService : IApplicationService
    {
        /// <summary>
        /// 增加新的仓库
        /// </summary>
        /// <param name="input"></param>
        void CreateWarehouse(CreateWarehouseInput input);

        /// <summary>
        /// 删除原有的仓库
        /// </summary>
        /// <param name="input"></param>
        void DeleteWarehouse(DeleteWarehouseInput input);

        /// <summary>
        /// 编辑仓库
        /// </summary>
        /// <param name="input"></param>
        void EditWarehouse(EditWarehouseInput input);

        /// <summary>
        /// 仓库基本信息查询
        /// </summary>
        /// <param name="input"></param>
        SearchWarehouseOutput SearchWarehouse(SearchWarehouseInput input);

        /// <summary>
        /// 仓库信息的分页查询
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        SearchWarehousesOutput SearchWarehouses(SearchWarehousesInput input);
    }
}
