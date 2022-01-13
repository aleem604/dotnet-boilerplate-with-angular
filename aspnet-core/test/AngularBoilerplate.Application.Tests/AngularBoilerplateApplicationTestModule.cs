using Volo.Abp.Modularity;

namespace AngularBoilerplate;

[DependsOn(
    typeof(AngularBoilerplateApplicationModule),
    typeof(AngularBoilerplateDomainTestModule)
    )]
public class AngularBoilerplateApplicationTestModule : AbpModule
{

}
