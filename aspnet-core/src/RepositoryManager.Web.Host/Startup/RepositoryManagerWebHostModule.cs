using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RepositoryManager.Configuration;

namespace RepositoryManager.Web.Host.Startup
{
    [DependsOn(
       typeof(RepositoryManagerWebCoreModule))]
    public class RepositoryManagerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RepositoryManagerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RepositoryManagerWebHostModule).GetAssembly());
        }
    }
}
