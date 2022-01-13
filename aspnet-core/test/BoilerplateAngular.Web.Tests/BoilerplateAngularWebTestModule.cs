using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateAngular.EntityFrameworkCore;
using BoilerplateAngular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BoilerplateAngular.Web.Tests
{
    [DependsOn(
        typeof(BoilerplateAngularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BoilerplateAngularWebTestModule : AbpModule
    {
        public BoilerplateAngularWebTestModule(BoilerplateAngularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateAngularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BoilerplateAngularWebMvcModule).Assembly);
        }
    }
}