using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace boilerplate-angular.EntityFrameworkCore
{
    public static class boilerplate-angularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<boilerplate-angularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<boilerplate-angularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
