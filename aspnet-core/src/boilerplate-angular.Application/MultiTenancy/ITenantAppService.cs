using Abp.Application.Services;
using boilerplate-angular.MultiTenancy.Dto;

namespace boilerplate-angular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

