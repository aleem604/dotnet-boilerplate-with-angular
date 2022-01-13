using AngularBoilerplate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AngularBoilerplate;

[DependsOn(
    typeof(AngularBoilerplateEntityFrameworkCoreTestModule)
    )]
public class AngularBoilerplateDomainTestModule : AbpModule
{

}
