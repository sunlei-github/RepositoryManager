using Abp.Application.Services;
using RepositoryManager.Business.Warehouse.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.IAppService
{
    public interface IWarehouseProductAppService : IApplicationService
    {
        /// <summary>
        /// 增加新的产品
        /// </summary>
        void CreateProduct(CreateWarehouseProductInput input);

        /// <summary>
        /// 编辑产品
        /// </summary>
        void EditProduct(EditWarehouseProductInput input);

        /// <summary>
        /// 删除产品
        /// </summary>
        void DeleteProduct(DeleteWarehouseProductInput input);

    }
}
