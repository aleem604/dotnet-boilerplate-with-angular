using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using boilerplate-angular.Authorization.Roles;
using boilerplate-angular.Authorization.Users;
using boilerplate-angular.MultiTenancy;

namespace boilerplate-angular.EntityFrameworkCore
{
    public class boilerplate-angularDbContext : AbpZeroDbContext<Tenant, Role, User, boilerplate-angularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public boilerplate-angularDbContext(DbContextOptions<boilerplate-angularDbContext> options)
            : base(options)
        {
        }
    }
}
