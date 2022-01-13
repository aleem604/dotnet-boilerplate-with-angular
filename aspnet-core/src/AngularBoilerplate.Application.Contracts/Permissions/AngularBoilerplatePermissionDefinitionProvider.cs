using AngularBoilerplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AngularBoilerplate.Permissions;

public class AngularBoilerplatePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AngularBoilerplatePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AngularBoilerplatePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AngularBoilerplateResource>(name);
    }
}
