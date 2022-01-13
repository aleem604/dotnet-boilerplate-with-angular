using AngularBoilerplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AngularBoilerplate.Permissions;

public class AngularBoilerplatePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AngularBoilerplatePermissions.GroupName);
		//Define your own permissions here. Example:
		myGroup.AddPermission(AngularBoilerplatePermissions.CrudProduct, L("Permission:CrudProduct"), MultiTenancySides.Both);
	}

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AngularBoilerplateResource>(name);
    }
}
