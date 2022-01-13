using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AngularBoilerplate.Data;
using Volo.Abp.DependencyInjection;

namespace AngularBoilerplate.EntityFrameworkCore;

public class EntityFrameworkCoreAngularBoilerplateDbSchemaMigrator
    : IAngularBoilerplateDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAngularBoilerplateDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AngularBoilerplateDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AngularBoilerplateDbContext>()
            .Database
            .MigrateAsync();
    }
}
