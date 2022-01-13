using AngularBoilerplate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AngularBoilerplate.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AngularBoilerplateEntityFrameworkCoreModule),
    typeof(AngularBoilerplateApplicationContractsModule)
    )]
public class AngularBoilerplateDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
