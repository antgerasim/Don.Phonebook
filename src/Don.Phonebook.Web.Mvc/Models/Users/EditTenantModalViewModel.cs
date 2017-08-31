using System.Collections.Generic;
using System.Linq;
using Don.Phonebook.Roles.Dto;
using Don.Phonebook.Users.Dto;

namespace Don.Phonebook.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}