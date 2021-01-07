using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using RepositoryManager.Business.Warehouse.Dto;
using RepositoryManager.Business.Warehouse.IAppService;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryManager.Business.Warehouse.AppService
{
    public class WarehouseAppService : RepositoryManagerAppServiceBase, IWarehouseAppService
    {
        private readonly IRepository<DbWarehouse> _warehouseRepository;

        public WarehouseAppService(IRepository<DbWarehouse> warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }
        public void CreateWarehouse(CreateWarehouseInput input)
        {
            var warehouseEntity = ObjectMapper.Map<DbWarehouse>(input);

            _warehouseRepository.Insert(warehouseEntity);
        }

        public void DeleteWarehouse(DeleteWarehouseInput input)
        {
            //简单的方法
            _warehouseRepository.Delete(c => c.Id == input.Id);
        }

        public void EditWarehouse(EditWarehouseInput input)
        {
            var warehouseEntity = _warehouseRepository.Get(input.Id);
            if (warehouseEntity == null)
            {
                throw new UserFriendlyException($"找不到对应的数据{input.Id}");
            }

            ObjectMapper.Map(input, warehouseEntity);
            _warehouseRepository.Update(warehouseEntity);
        }

        public SearchWarehouseOutput SearchWarehouse(SearchWarehouseInput input)
        {
            var warehouseEntity = _warehouseRepository.FirstOrDefault(input.Id);
            if (warehouseEntity == null)
            {
                throw new UserFriendlyException($"找不到对应的数据{input.Id}");
            }

            return ObjectMapper.Map<SearchWarehouseOutput>(warehouseEntity);
        }

        public SearchWarehousesOutput SearchWarehouses(SearchWarehousesInput input)
        {
            var warehouseEntities = _warehouseRepository.GetAll()
                .WhereIf(!string.IsNullOrEmpty(input.WarehouseAddress), c => c.WarehouseAddress.Contains(input.WarehouseAddress))
                .WhereIf(!string.IsNullOrEmpty(input.WarehouseName), c => c.WarehouseName.Contains(input.WarehouseAddress));

            var pageWarehouseEntities = warehouseEntities.PageBy(input).ToList();

            return new SearchWarehousesOutput
            {
                TotalCount = pageWarehouseEntities.Count,
                Items = ObjectMapper.Map<List<WarehouseDto>>(pageWarehouseEntities)
            };
        }
    }
}
