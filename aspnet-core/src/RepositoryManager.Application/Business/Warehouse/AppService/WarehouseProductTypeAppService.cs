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
using System.Threading.Tasks;

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

        public void CreateProductType(CreateWarehouseProductTypeInput input)
        {
            var proTypeEntity = ObjectMapper.Map<DbWarehouseProductType>(input);

            _warehouseProductTypeRepository.Insert(proTypeEntity);
        }

        public void DeleteProductType(DeleteWarehouseProductTypeInput input)
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

        public void EditProductType(EditWarehouseProductTypeInput input)
        {
            var proTypeEntity = _warehouseProductTypeRepository.Get(input.Id);
            if (proTypeEntity == null)
            {
                throw new UserFriendlyException($"找不到对应的数据{input.Id}");
            }

            ObjectMapper.Map(input, proTypeEntity);
            _warehouseProductTypeRepository.Update(proTypeEntity);
        }

        public async Task<WarehouseProductTypesOutput> GetProducetTypes()
        {
            var proTypes = (await _warehouseProductTypeRepository.GetAllListAsync());
            var topProTypeEntities = proTypes.Where(c => !c.ParentId.HasValue);
            var sonProTypeEntities = proTypes.Where(c => c.ParentId.HasValue);

            WarehouseProductTypesOutput output = new WarehouseProductTypesOutput();
            output.WarehouseProductTypes = new List<WarehouseProductTypesDto>();

            foreach (var topProType in topProTypeEntities)
            {
                var proTypeDto = ObjectMapper.Map<WarehouseProductTypesDto>(topProType);
                GetAllChildrenProducetTypes(proTypeDto, sonProTypeEntities);

                output.WarehouseProductTypes.Add(proTypeDto);
            }

            return output;
        }

        /// <summary>
        ///  获取父级对应的子级的产品类型
        /// </summary>
        /// <param name="parentProductType"></param>
        /// <param name="sonProductTypes"></param>
        /// <returns></returns>
        private  void GetAllChildrenProducetTypes(WarehouseProductTypesDto parentProductType,IEnumerable<DbWarehouseProductType> sonProductTypes)
        {
            parentProductType.WarehouseProductTypeDtos = ObjectMapper.Map<List<WarehouseProductTypesDto>>(sonProductTypes.Where(c => c.ParentId == parentProductType.Id));

            foreach (var productType in parentProductType.WarehouseProductTypeDtos)
            {
                productType.WarehouseProductTypeDtos = new List<WarehouseProductTypesDto>();
                GetAllChildrenProducetTypes(productType, sonProductTypes);
            }
        }
    }
}
