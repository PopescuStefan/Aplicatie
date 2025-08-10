using AplicatieMedicala.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AplicatieMedicala.Permissions;

public class AplicatieMedicalaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AplicatieMedicalaPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AplicatieMedicalaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AplicatieMedicalaResource>(name);
    }
}
