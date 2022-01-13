using Abp.Application.Services.Dto;

namespace boilerplate-angular.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

