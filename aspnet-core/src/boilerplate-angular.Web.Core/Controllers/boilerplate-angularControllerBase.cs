using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace boilerplate-angular.Controllers
{
    public abstract class boilerplate-angularControllerBase: AbpController
    {
        protected boilerplate-angularControllerBase()
        {
            LocalizationSourceName = boilerplate-angularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
