﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RepositoryManager.Authorization;

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
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RepositoryManagerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
