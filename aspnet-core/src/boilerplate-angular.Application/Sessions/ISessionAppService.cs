using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplate-angular.Sessions.Dto;

namespace boilerplate-angular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
