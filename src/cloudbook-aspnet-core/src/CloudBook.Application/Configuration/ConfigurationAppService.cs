using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CloudBook.Configuration.Dto;

namespace CloudBook.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CloudBookAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
