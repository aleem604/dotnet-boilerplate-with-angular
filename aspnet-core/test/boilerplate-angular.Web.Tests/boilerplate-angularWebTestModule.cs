using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplate-angular.EntityFrameworkCore;
using boilerplate-angular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace boilerplate-angular.Web.Tests
{
    [DependsOn(
        typeof(boilerplate-angularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class boilerplate-angularWebTestModule : AbpModule
    {
        public boilerplate-angularWebTestModule(boilerplate-angularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boilerplate-angularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(boilerplate-angularWebMvcModule).Assembly);
        }
    }
}