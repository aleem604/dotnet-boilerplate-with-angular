using System;
using System.Collections.Generic;
using System.Text;
using AngularBoilerplate.Localization;
using Volo.Abp.Application.Services;

namespace AngularBoilerplate;

/* Inherit your application services from this class.
 */
public abstract class AngularBoilerplateAppService : ApplicationService
{
    protected AngularBoilerplateAppService()
    {
        LocalizationResource = typeof(AngularBoilerplateResource);
    }
}
