using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using RepositoryManager.Authorization.Users;
using RepositoryManager.MultiTenancy;
using Abp.Runtime.Caching;

namespace RepositoryManager
{
    /// <summary>
    /// Derive your application services from this class.
    /// 业务程序类的基类 
    /// </summary>
    public abstract class RepositoryManagerAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected RepositoryManagerAppServiceBase()
        {
            LocalizationSourceName = RepositoryManagerConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());

            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
