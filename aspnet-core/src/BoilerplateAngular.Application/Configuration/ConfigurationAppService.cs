using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BoilerplateAngular.Configuration.Dto;

namespace BoilerplateAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BoilerplateAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
