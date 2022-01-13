using System.Threading.Tasks;

namespace AngularBoilerplate.Data;

public interface IAngularBoilerplateDbSchemaMigrator
{
    Task MigrateAsync();
}
