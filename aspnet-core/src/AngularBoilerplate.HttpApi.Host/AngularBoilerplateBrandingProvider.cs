using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AngularBoilerplate;

[Dependency(ReplaceServices = true)]
public class AngularBoilerplateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AngularBoilerplate";
}
