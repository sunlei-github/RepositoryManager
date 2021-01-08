using Abp.MultiTenancy;
using Abp.Zero.Configuration;

namespace RepositoryManager.Authorization.Roles
{
    public static class AppRoleConfig
    {
        public static void Configure(IRoleManagementConfig roleManagementConfig)
        {
            // Static host roles
            // 添加静态角色

            roleManagementConfig.StaticRoles.Add(
                new StaticRoleDefinition(
                    StaticRoleNames.Host.Admin,
                    StaticRoleNames.Host.AdminDisplay,
                    MultiTenancySides.Host
                )
            );

            // Static tenant roles
            // 去掉 租户 部分
            //roleManagementConfig.StaticRoles.Add(
            //    new StaticRoleDefinition(
            //        StaticRoleNames.Tenants.Admin,
            //        MultiTenancySides.Tenant
            //    )
            //);
        }
    }
}
