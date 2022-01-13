using Abp.Authorization;
using boilerplate-angular.Authorization.Roles;
using boilerplate-angular.Authorization.Users;

namespace boilerplate-angular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
