using STD.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace STD.Permissions;

public class STDPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(STDPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(STDPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<STDResource>(name);
    }
}
