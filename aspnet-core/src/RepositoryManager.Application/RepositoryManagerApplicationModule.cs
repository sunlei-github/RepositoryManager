using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RepositoryManager.Authorization;
using RepositoryManager.Business.Warehouse.Dto;
using RepositoryManager.Entities.WarehouseEntities;

namespace RepositoryManager
{
    [DependsOn(
        typeof(RepositoryManagerCoreModule),
        typeof(AbpAutoMapperModule))]
    public class RepositoryManagerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RepositoryManagerAuthorizationProvider>();

            //不映射某个属性
            //Configuration.Modules.AbpAutoMapper().Configurators.Add(
            //    cfg =>
            //    {
            //        cfg.CreateMap<WarehouseProductTypeDto, DbWarehouseProductType>()
            //        .ForMember(c => c.ParentId, opt => opt.Ignore());
            //    });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RepositoryManagerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg =>
                {
                    cfg.AddMaps(thisAssembly);
                }

            );
        }
    }
}
