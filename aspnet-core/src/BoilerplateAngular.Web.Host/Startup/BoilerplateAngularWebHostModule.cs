using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateAngular.Configuration;

namespace BoilerplateAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(BoilerplateAngularWebCoreModule))]
    public class BoilerplateAngularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerplateAngularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateAngularWebHostModule).GetAssembly());
        }
    }
}
