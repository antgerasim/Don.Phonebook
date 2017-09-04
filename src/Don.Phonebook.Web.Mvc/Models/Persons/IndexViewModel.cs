using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Don.Phonebook.Persons.Dto;

namespace Don.Phonebook.Web.Models.Persons
{
    [AutoMapFrom(typeof(ListResultDto<PersonListDto>))]
    public class IndexViewModel: ListResultDto<PersonListDto>
    {
        public IndexViewModel(ListResultDto<PersonListDto> output)
        {
            output.MapTo(this);

        }

    }
}
