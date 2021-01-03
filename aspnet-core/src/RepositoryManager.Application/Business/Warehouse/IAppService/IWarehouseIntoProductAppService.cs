using Abp.Application.Services;
using RepositoryManager.Business.Warehouse.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using static RepositoryManager.Business.Warehouse.Dto.WarehouseIntoProductDto;

namespace RepositoryManager.Business.Warehouse.IAppService
{
   public interface IWarehouseIntoProductAppService :IApplicationService
    {
        /// <summary>
        /// 新增仓库入库
        /// </summary>
        /// <param name="input"></param>
        void CreateWarehouseIntoProduct(CreateWarehouseIntoProduct input);

        /// <summary>
        /// 仓库入库基本信息查询
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        SearchWarehouseIntoProductOutput SearchWarehouseIntoProduct (SearchWarehouseIntoProductInput input);
    }
}
