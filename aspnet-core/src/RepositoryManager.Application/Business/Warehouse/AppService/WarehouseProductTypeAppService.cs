using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using RepositoryManager.Business.Warehouse.Dto;
using RepositoryManager.Business.Warehouse.IAppService;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.AppService
{
    public class WarehouseProductTypeAppService : ApplicationService, IWarehouseProductTypeAppService
    {

        private readonly IRepository<DbWarehouseProductType> _warehouseProductTypeRepository;

        /// <summary>
        /// DI
        /// </summary>
        public WarehouseProductTypeAppService(IRepository<DbWarehouseProductType> warehouseProductTypeRepository)
        {
            _warehouseProductTypeRepository = warehouseProductTypeRepository;
        }

        public void CreateProductType(CreateWarehouseProductType input)
        {
            var proTypeEntity = ObjectMapper.Map<DbWarehouseProductType>(input);

            _warehouseProductTypeRepository.Insert(proTypeEntity);
        }

        public void DeleteProductType(DeleteWarehouseProductType input)
        {
            var proTypeEntity = _warehouseProductTypeRepository.FirstOrDefault(c => c.Id == input.Id);
            if (proTypeEntity == null)
            {
                throw new UserFriendlyException($"找不到对应的数据{input.Id}");
            }

            //如果要删除的类型 还有子级的类型 则不能删除
            var sonProTypeEntites = _warehouseProductTypeRepository.FirstOrDefault(c => c.ParentId == proTypeEntity.Id);
            if (proTypeEntity == null)
            {
                throw new UserFriendlyException("要删除的类型还有子级类型不能删除！");
            }

            _warehouseProductTypeRepository.Delete(c => c.Id == input.Id);
        }

        public void EditProductType(EditWarehouseProductType input)
        {
            var proTypeEntity = _warehouseProductTypeRepository.Get(input.Id);
            if (proTypeEntity == null)
            {
                throw new UserFriendlyException($"找不到对应的数据{input.Id}");
            }

            proTypeEntity = ObjectMapper.Map<DbWarehouseProductType>(input);
            _warehouseProductTypeRepository.Update(proTypeEntity);
        }
    }
}
