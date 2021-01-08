using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace RepositoryManager.Authorization
{
    public class RepositoryManagerAuthorizationProvider : AuthorizationProvider
    {
        /// <summary>
        /// 创建都有哪些权限   可以为一个权限 设置 子权限
        /// 
        /// 官方文档参考地址
        /// 摘自官网：https://aspnetboilerplate.com/Pages/Documents/Authorization
        /// Name：系统范围内的唯一名称。为权限名称而不是魔术字符串定义const字符串是个好主意。我们更喜欢使用。（点）表示层次结构名称，但这不是必需的。您可以设置任何喜欢的名称。唯一的规则是它必须是唯一的
        /// Display name：可本地化的字符串，可用于稍后在UI中显示权限
        /// Description：可本地化的字符串，可用于稍后在UI中显示权限的定义
        /// MultiTenancySides：对于多租户应用程序，租户或主机可以使用权限。这是一个Flags枚举，因此可以在两边使用权限
        /// featureDependency：可用于声明依赖于 功能。因此，只有在满足功能依赖性的情况下，才能授予此权限。它等待实现IFeatureDependency的对象。默认实现是SimpleFeatureDependency类。用法示例： new SimpleFeatureDependency("MyFeatureName")
        /// </summary>
        /// <param name="context"></param>
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //var parentPer = context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            //parentPer.CreateChildPermission("子权限",“子权限显示名称”);


            //context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            //context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            //context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        /// <summary>
        /// 本地化  
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, RepositoryManagerConsts.LocalizationSourceName);
        }
    }
}
