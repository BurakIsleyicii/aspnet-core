using CoinEx.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CoinEx.Permissions
{
    public class CoinExPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CoinExPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CoinExPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CoinExResource>(name);
        }
    }
}
