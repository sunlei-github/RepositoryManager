using Abp.AutoMapper;
using RepositoryManager.Authorization.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Cache.Dto
{
    [AutoMap(typeof(Role))]
    public class RoleCacheDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string NormalizedName { get; set; }

        public string Description { get; set; }

        public List<string> GrantedPermissions { get; set; }
    }
}
