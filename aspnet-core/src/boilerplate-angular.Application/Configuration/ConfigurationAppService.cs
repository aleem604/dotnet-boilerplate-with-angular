using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using boilerplate-angular.Configuration.Dto;

namespace boilerplate-angular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : boilerplate-angularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
