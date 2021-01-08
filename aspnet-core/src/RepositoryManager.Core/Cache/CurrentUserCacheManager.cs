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
using Abp.Domain.Services;

namespace RepositoryManager.Cache
{
    /// <summary>
    /// 使用DomainService定义一个域服务
    /// 官方文档相关地址：https://aspnetboilerplate.com/Pages/Documents/Domain-Services
    /// </summary>
    public class CurrentUserCacheManager : DomainService
    {
        public ITypedCache<string, UserCacheDto> TypedCache { set; get; }

        public UserManager UserManager { set; get; }

        public IAbpSession AbpSession { set; get; }

        /// <summary>
        /// 设置登陆用户的缓存
        /// </summary>
        public void SetCurrentUserMessage()
        {
            long currentUserId = AbpSession.GetUserId();
            string currentUserKey = GetCurrentUserCacheKey(currentUserId);

            var currentUser = UserManager.GetUserById(currentUserId);
            var currentUserDto = ObjectMapper.Map<UserCacheDto>(currentUser);
            var currentUserRoles = UserManager.GetCurrentUserRoles();
            currentUserDto.Roles = ObjectMapper.Map<List<RoleCacheDto>>(currentUserRoles);

            TypedCache.Set(currentUserKey, currentUserDto);
        }

        /// <summary>
        /// 从缓存中获取登陆用户信息
        /// </summary>
        /// <returns></returns>
        public UserCacheDto GetCurrentUserMessage()
        {
            string currentUserKey = GetCurrentUserCacheKey();

            return TypedCache.GetOrDefault(currentUserKey);
        }

        /// <summary>
        /// 清除当前登录的用户信息
        /// </summary>
        public void ClearCurrentUserMessage()
        {
            string currentUserKey = GetCurrentUserCacheKey();
            TypedCache.Remove(currentUserKey);
        }

        /// <summary>
        /// 判断是否包含当前登录人信息的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public UserCacheDto CheckSetCacheCurrentUserMsg()
        {
            UserCacheDto userCacheDto = null;
            if (!TypedCache.TryGetValue(GetCurrentUserCacheKey(), out userCacheDto))
            {
                SetCurrentUserMessage();
            }

            return userCacheDto;
        }

        /// <summary>
        /// 获取登陆用户缓存的Key
        /// </summary>
        /// <returns></returns>
        public string GetCurrentUserCacheKey()
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
