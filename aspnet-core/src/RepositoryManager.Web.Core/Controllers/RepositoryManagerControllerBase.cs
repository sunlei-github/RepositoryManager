using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RepositoryManager.Controllers
{
    public abstract class RepositoryManagerControllerBase: AbpController
    {
        protected RepositoryManagerControllerBase()
        {
            LocalizationSourceName = RepositoryManagerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
