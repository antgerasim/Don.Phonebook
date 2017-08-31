using System.Collections.Generic;
using Don.Phonebook.Roles.Dto;
using Don.Phonebook.Users.Dto;

namespace Don.Phonebook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}