using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerplateAngular.Authorization.Accounts.Dto;

namespace BoilerplateAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
