using Abp.Application.Services;
using Abp.Domain.Repositories;
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
    public class WarehouseInventoryAppService : ApplicationService, IWarehouseInventoryAppService
    {

        public readonly IRepository<DbWarehouseInventory> _warehouseInventoryRepository;

        public WarehouseInventoryAppService(IRepository<DbWarehouseInventory> warehouseInventoryRepository) 
        {
            _warehouseInventoryRepository = warehouseInventoryRepository;
        }
        public void CreateWarehouseInventory(CreateWarehouseInventoryInput input)
        {
            var WarehouseInventoryEntity = ObjectMapper.Map<DbWarehouseInventory>(input);

            _warehouseInventoryRepository.Insert(WarehouseInventoryEntity);
        }

        public void DeleteWarehouseInventory(DeleteWarehouseInventoryInput input)
        {
            var WarehouseInventoryEntity = _warehouseInventoryRepository.FirstOrDefault(input.Id);
            if (WarehouseInventoryEntity==null)
            {
                throw new UserFriendlyException($"找不到此数据{input.Id}");
            }

            _warehouseInventoryRepository.Delete(c => c.Id==input.Id);
        }

        public void EditWarehouseInventory(EditWarehouseInventoryInput input)
        {
            var WarehouseInventoryEntity = _warehouseInventoryRepository.FirstOrDefault(input.Id);
            if (WarehouseInventoryEntity==null)
            {
                throw new UserFriendlyException($"找不到此数据{input.Id}");
            }

            _warehouseInventoryRepository.Update(WarehouseInventoryEntity);
        }

        public SearchWarehouseInventoryOutput SearchWarehouseInventory(SearchWarehouseInventoryInput input)
        {
            var WarehouseInventoryEntity = _warehouseInventoryRepository.FirstOrDefault(input.Id);
            if (WarehouseInventoryEntity==null)
            {
                throw new UserFriendlyException($"找不到此数据{input.Id}");
            }
            return ObjectMapper.Map<SearchWarehouseInventoryOutput>(WarehouseInventoryEntity);

        }
    }
}
