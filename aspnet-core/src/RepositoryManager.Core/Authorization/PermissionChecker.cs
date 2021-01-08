using Abp.Authorization;
using RepositoryManager.Authorization.Roles;
using RepositoryManager.Authorization.Users;

namespace RepositoryManager.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        /// <summary>
        /// 定义权限检查
        /// </summary>
        /// <param name="userManager"></param>
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
