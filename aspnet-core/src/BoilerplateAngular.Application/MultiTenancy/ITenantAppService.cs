using Abp.Application.Services;
using BoilerplateAngular.MultiTenancy.Dto;

namespace BoilerplateAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

