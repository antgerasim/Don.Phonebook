using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Authorization;
using Abp.MultiTenancy;

namespace Don.Phonebook.Roles.Dto
{
    [AutoMapFrom(typeof(Permission))]
    public class PermissionDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        //don added works!
        public string Parent { get; set; }
        /*    public IReadOnlyList<string> Children { get; set; }*/
        public IReadOnlyList<PermissionDto> Children { get; set; }

        public string MultiTenancySides { get; set; }
    }
}