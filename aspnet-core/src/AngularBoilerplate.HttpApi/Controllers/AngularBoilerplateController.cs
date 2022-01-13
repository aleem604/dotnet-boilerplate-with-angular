using AngularBoilerplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AngularBoilerplate.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AngularBoilerplateController : AbpControllerBase
{
    protected AngularBoilerplateController()
    {
        LocalizationResource = typeof(AngularBoilerplateResource);
    }
}
