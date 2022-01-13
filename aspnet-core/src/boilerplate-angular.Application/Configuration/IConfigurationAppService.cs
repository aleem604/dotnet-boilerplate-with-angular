using System.Threading.Tasks;
using boilerplate-angular.Configuration.Dto;

namespace boilerplate-angular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
