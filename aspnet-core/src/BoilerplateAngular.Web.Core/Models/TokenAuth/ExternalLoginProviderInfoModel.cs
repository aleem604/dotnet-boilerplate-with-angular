using Abp.AutoMapper;
using BoilerplateAngular.Authentication.External;

namespace BoilerplateAngular.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
