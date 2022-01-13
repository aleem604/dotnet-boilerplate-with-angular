using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BoilerplateAngular.Controllers
{
    public abstract class BoilerplateAngularControllerBase: AbpController
    {
        protected BoilerplateAngularControllerBase()
        {
            LocalizationSourceName = BoilerplateAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
