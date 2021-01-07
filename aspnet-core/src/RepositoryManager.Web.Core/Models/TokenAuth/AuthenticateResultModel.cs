namespace RepositoryManager.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }

        /// <summary>
        /// 将jwt 在此加密
        /// </summary>
        //public string EncryptedAccessToken { get; set; }

        /// <summary>
        /// jwt 的过期时间
        /// </summary>
        public int ExpireInSeconds { get; set; }

        /// <summary>
        /// 登录的用户的Id
        /// </summary>
        public long UserId { get; set; }
    }
}
