using Abp.AutoMapper;
using RepositoryManager.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryManager.Cache.Dto
{
    [AutoMap(typeof(User))]
    public class UserCacheDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        /// <summary>
        /// 登陆用户的角色
        /// </summary>
        public List<RoleCacheDto> Roles { set; get; }
    }
}
