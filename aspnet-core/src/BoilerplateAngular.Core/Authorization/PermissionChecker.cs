using Abp.Authorization;
using BoilerplateAngular.Authorization.Roles;
using BoilerplateAngular.Authorization.Users;

namespace BoilerplateAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
