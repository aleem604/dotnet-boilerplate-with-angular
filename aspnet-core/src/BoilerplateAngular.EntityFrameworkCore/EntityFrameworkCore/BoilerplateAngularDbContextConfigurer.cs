using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateAngular.EntityFrameworkCore
{
    public static class BoilerplateAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BoilerplateAngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BoilerplateAngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
