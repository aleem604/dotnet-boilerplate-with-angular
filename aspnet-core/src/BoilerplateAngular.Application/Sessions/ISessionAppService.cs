using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerplateAngular.Sessions.Dto;

namespace BoilerplateAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
