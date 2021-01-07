using Abp.Dependency;
using Abp.Runtime.Caching;
using Microsoft.AspNetCore.Identity;
using RepositoryManager.Common.Const;
using System;
using System.Collections.Generic;
using System.Text;
using RepositoryManager.Authorization.Users;
using RepositoryManager.Cache.Dto;
using RepositoryManager.Authorization.Roles;
using Abp.Runtime.Session;
using Abp.ObjectMapping;

namespace RepositoryManager.Cache
{
    public class CacheManager:ITransientDependency
    {
        public ITypedCache<string, UserCacheDto> TypedCache { set; get; }

        public UserManager UserManager { set; get; }

        public RoleManager RoleManager { set; get; }

        public IAbpSession AbpSession { set; get; }

        public IObjectMapper ObjectMapper { set; get; }

        /// <summary>
        /// 设置登陆用户的缓存
        /// </summary>
        protected void SetCurrentUserMessage()
        {
            long currentUserId = AbpSession.GetUserId();
            string currentUserKey = GetCurrentUserCacheKey(currentUserId);

            var currentUser = UserManager.GetUserById(currentUserId);
            var currentUserDto = ObjectMapper.Map<UserCacheDto>(currentUser);

            TypedCache.Set(currentUserKey, currentUserDto);
        }

        /// <summary>
        /// 从缓存中获取登陆用户信息
        /// </summary>
        /// <returns></returns>
        protected UserCacheDto GetCurrentUserMessage()
        {
            string currentUserKey = GetCurrentUserCacheKey();

            return TypedCache.GetOrDefault(currentUserKey);
        }

        /// <summary>
        /// 清除当前登录的用户信息
        /// </summary>
        protected void ClearCurrentUserMessage()
        {
            string currentUserKey = GetCurrentUserCacheKey();
            TypedCache.Remove(currentUserKey);
        }

        /// <summary>
        /// 获取登陆用户缓存的Key
        /// </summary>
        /// <returns></returns>
        protected string GetCurrentUserCacheKey()
        {
            long currentUserId = AbpSession.GetUserId();

            return GetCurrentUserCacheKey(currentUserId);
        }

        /// <summary>
        /// 获取登陆用户缓存的Key
        /// </summary>
        /// <returns></returns>
        private string GetCurrentUserCacheKey(long currentUserId)
        {
            return $"{CacheConst.ACCOUNT_USER_ID}{currentUserId}";
        }

    }
}
