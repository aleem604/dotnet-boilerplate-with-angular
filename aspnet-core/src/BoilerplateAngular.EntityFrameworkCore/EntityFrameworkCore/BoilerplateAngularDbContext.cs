using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BoilerplateAngular.Authorization.Roles;
using BoilerplateAngular.Authorization.Users;
using BoilerplateAngular.MultiTenancy;

namespace BoilerplateAngular.EntityFrameworkCore
{
    public class BoilerplateAngularDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerplateAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerplateAngularDbContext(DbContextOptions<BoilerplateAngularDbContext> options)
            : base(options)
        {
        }
    }
}
