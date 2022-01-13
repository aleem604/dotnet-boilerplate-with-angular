using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplate-angular.Configuration;

namespace boilerplate-angular.Web.Host.Startup
{
    [DependsOn(
       typeof(boilerplate-angularWebCoreModule))]
    public class boilerplate-angularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public boilerplate-angularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boilerplate-angularWebHostModule).GetAssembly());
        }
    }
}
