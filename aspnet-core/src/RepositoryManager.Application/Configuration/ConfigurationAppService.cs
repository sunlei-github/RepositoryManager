using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RepositoryManager.Configuration.Dto;

namespace RepositoryManager.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RepositoryManagerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
