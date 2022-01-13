using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplate-angular.Authorization;

namespace boilerplate-angular
{
    [DependsOn(
        typeof(boilerplate-angularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class boilerplate-angularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<boilerplate-angularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(boilerplate-angularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
