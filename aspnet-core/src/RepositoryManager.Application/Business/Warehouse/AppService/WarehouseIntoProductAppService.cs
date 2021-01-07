using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using RepositoryManager.Business.Warehouse.Dto;
using RepositoryManager.Business.Warehouse.IAppService;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;
using static RepositoryManager.Business.Warehouse.Dto.WarehouseIntoProductDto;

namespace RepositoryManager.Business.Warehouse.AppService
{
    public class WarehouseIntoProductAppService : RepositoryManagerAppServiceBase, IWarehouseIntoProductAppService
    {
        private readonly IRepository<DbWarehouseIntoProduct> _warehouseIntoProductRepository = null;

        public WarehouseIntoProductAppService(IRepository<DbWarehouseIntoProduct> warehouseIntoProductRepository)
        {
            _warehouseIntoProductRepository = warehouseIntoProductRepository;
        }

        public void CreateWarehouseIntoProduct(CreateWarehouseIntoProduct input)
        {
            var IntoProEntity = ObjectMapper.Map<DbWarehouseIntoProduct>(input);

            _warehouseIntoProductRepository.Insert(IntoProEntity);
        }

        public SearchWarehouseIntoProductOutput SearchWarehouseIntoProduct(SearchWarehouseIntoProductInput input)
        {
            var IntoProEntity = _warehouseIntoProductRepository.FirstOrDefault(input.Id);

            if (IntoProEntity == null)
            {
                throw new UserFriendlyException($"找不到对应值{input.Id}");
            }

            return ObjectMapper.Map<SearchWarehouseIntoProductOutput>(IntoProEntity);
        }
    }
}
