using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RepositoryManager.EntityFrameworkCore;
using RepositoryManager.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace RepositoryManager.Web.Tests
{
    [DependsOn(
        typeof(RepositoryManagerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class RepositoryManagerWebTestModule : AbpModule
    {
        public RepositoryManagerWebTestModule(RepositoryManagerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RepositoryManagerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RepositoryManagerWebMvcModule).Assembly);
        }
    }
}