using Abp.Application.Services.Dto;

namespace BoilerplateAngular.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

