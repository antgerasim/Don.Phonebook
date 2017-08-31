using Abp.Authorization;
using Don.Phonebook.Authorization.Roles;
using Don.Phonebook.Authorization.Users;

namespace Don.Phonebook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
