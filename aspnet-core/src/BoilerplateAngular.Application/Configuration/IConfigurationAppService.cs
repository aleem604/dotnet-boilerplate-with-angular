using System.Threading.Tasks;
using BoilerplateAngular.Configuration.Dto;

namespace BoilerplateAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
