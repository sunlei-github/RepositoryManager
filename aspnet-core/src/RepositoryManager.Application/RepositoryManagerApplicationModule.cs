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
            //注册 权限的提供者RepositoryManagerAuthorizationProvider
            Configuration.Authorization.Providers.Add<RepositoryManagerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RepositoryManagerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);


            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                //这里 会将 在程序中定义的autoMapper的Profile(配置对应的映射关系)  注入进来 
                //手动添加   Configuration.Modules.AbpAutoMapper().Configurators.Add(c => { c.AddProfile<TProfile> })
                cfg =>
                {
                    cfg.AddMaps(thisAssembly);
                }

            ); 
        }
    }
}
