using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AngularBoilerplate.Data;

/* This is used if database provider does't define
 * IAngularBoilerplateDbSchemaMigrator implementation.
 */
public class NullAngularBoilerplateDbSchemaMigrator : IAngularBoilerplateDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
