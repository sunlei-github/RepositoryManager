﻿using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.AspNetCore.Mvc;
using RepositoryManager.Business.Warehouse.Dto;
using RepositoryManager.Business.Warehouse.IAppService;
using RepositoryManager.Entities.WarehouseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Business.Warehouse.AppService
{
    /// <summary>
    /// 产品服务
    /// </summary>
    public class WarehouseProductAppService : RepositoryManagerAppServiceBase, IWarehouseProductAppService
    {
        private readonly IRepository<DbWarehouseProduct> _warehouseProductRepository;

        /// <summary>
        /// DI
        /// </summary>
        /// <param name="warehouseProductRepository"></param>
        public WarehouseProductAppService(IRepository<DbWarehouseProduct>  warehouseProductRepository)
        {
            _warehouseProductRepository = warehouseProductRepository;
        }

        public void CreateProduct(CreateWarehouseProductInput input)
        {
            var proEntity = ObjectMapper.Map<DbWarehouseProduct>(input);

            _warehouseProductRepository.Insert(proEntity);
        }

        public void DeleteProduct(DeleteWarehouseProductInput input)
        {
            _warehouseProductRepository.Delete(c => c.Id == input.Id);
        }

        public void EditProduct(EditWarehouseProductInput input)
        {
            var proEntity = _warehouseProductRepository.FirstOrDefault(c => c.Id == input.Id);
            if (proEntity == null)
            {
                throw new UserFriendlyException($"找不到对应的数据{input.Id}");
            }

            ObjectMapper.Map(input, proEntity);
            _warehouseProductRepository.Update(proEntity);
        }
    }
}
