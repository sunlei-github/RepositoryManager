using Abp.Application.Services;
using RepositoryManager.Business.Warehouse.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryManager.Business.Warehouse.IAppService
{
    /// <summary>
    /// 产品类型服务
    /// </summary>
    public interface IWarehouseProductTypeAppService : IApplicationService
    {
        /// <summary>
        /// 增加新的产品类型
        /// </summary>
        void CreateProductType(CreateWarehouseProductTypeInput input);

        /// <summary>
        /// 编辑产品类型
        /// </summary>
        void EditProductType(EditWarehouseProductTypeInput input);

        /// <summary>
        /// 删除产品类型 如果删除的类型下面还有子级产品类型 则不能删除
        /// </summary>
        void DeleteProductType(DeleteWarehouseProductTypeInput input);

        /// <summary>
        /// 获取所有的的货物类型
        /// </summary>
        /// <returns></returns>
        Task<WarehouseProductTypesOutput> GetProducetTypes();
    }
}
