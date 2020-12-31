using Abp.Authorization;
using RepositoryManager.Authorization.Roles;
using RepositoryManager.Authorization.Users;

namespace RepositoryManager.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
