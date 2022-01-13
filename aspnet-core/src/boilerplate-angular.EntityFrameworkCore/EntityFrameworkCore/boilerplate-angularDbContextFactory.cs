using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using boilerplate-angular.Configuration;
using boilerplate-angular.Web;

namespace boilerplate-angular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class boilerplate-angularDbContextFactory : IDesignTimeDbContextFactory<boilerplate-angularDbContext>
    {
        public boilerplate-angularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<boilerplate-angularDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            boilerplate-angularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(boilerplate-angularConsts.ConnectionStringName));

            return new boilerplate-angularDbContext(builder.Options);
        }
    }
}
