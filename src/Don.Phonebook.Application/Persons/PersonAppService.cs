using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Castle.Core.Internal;
using Don.Phonebook.Authorization;
using Don.Phonebook.Persons.Dto;

namespace Don.Phonebook.Persons
{
    [AbpAuthorize(PermissionNames.Pages_Tenant_PhoneBook)]
    public class PersonAppService : PhonebookAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public ListResultDto<PersonListDto> GetPeople(GetPeopleInput input)
        {
            var persons = _personRepository.GetAll().WhereIf(!input.Filter.IsNullOrEmpty(),
                p => p.Name.Contains(input.Filter) || p.Surname.Contains(input.Filter) ||
                     p.EmailAddress.Contains(input.Filter)).OrderBy(p => p.Name).ThenBy(p => p.Surname).ToList();

             return new ListResultDto<PersonListDto>(ObjectMapper.Map<List<PersonListDto>>(persons));
            //var retVal = persons.MapTo<List<PersonListDto>>();
            //return new ListResultDto<PersonListDto>(retVal);
        }

        public async Task CreatePerson(CreatePersonInput input)
        {
            var person = ObjectMapper.Map<Person>(input);
            await _personRepository.InsertAsync(person);
        }
    }
}