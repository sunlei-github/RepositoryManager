namespace RepositoryManager.Authorization.Roles
{
    public static class StaticRoleNames
    {
        public static class Host
        {
            public const string Admin = "Admin";

            /// <summary>
            /// admin显示在页面上的名称
            /// </summary>
            public const string AdminDisplay = "系统管理员";
        }

        public static class Tenants
        {
            public const string Admin = "Admin";
        }
    }
}
