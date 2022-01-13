using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AngularBoilerplate.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AngularBoilerplateDbContextFactory : IDesignTimeDbContextFactory<AngularBoilerplateDbContext>
{
    public AngularBoilerplateDbContext CreateDbContext(string[] args)
    {
        AngularBoilerplateEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AngularBoilerplateDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AngularBoilerplateDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AngularBoilerplate.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
