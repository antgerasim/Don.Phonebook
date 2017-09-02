using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Don.Phonebook.Persons.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto //used to inherit audit properties automatically
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        
    }
}