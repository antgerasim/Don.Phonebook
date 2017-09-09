using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Don.Phonebook.Authorization
{
    public class PhonebookAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"),
                multiTenancySides: MultiTenancySides.Host);

            /*Don added*/
            context.CreatePermission(PermissionNames.Pages_Tenant_PhoneBook, L("PhoneBook"),
                multiTenancySides: MultiTenancySides.Tenant);
            /*Don added end*/

            /*Don added*/
            var administration = context.CreatePermission(PermissionNames.Administration, L("Administration"));
            administration.CreateChildPermission(PermissionNames.Administration_RoleManagement,L("RoleManagement"));

            var userManagement = administration.CreateChildPermission(PermissionNames.Administration_UserManagement,L("UserManagement"));
            userManagement.CreateChildPermission(PermissionNames.Administration_UserManagement_CreateUser,L("CreateUser"));
            /*Don added end*/


        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, PhonebookConsts.LocalizationSourceName);
        }
    }
}