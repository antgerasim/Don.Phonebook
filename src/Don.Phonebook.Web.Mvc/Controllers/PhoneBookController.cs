using Don.Phonebook.Controllers;
using Don.Phonebook.Persons;
using Don.Phonebook.Persons.Dto;
using Don.Phonebook.Web.Models.Persons;
using Microsoft.AspNetCore.Mvc;

namespace Don.Phonebook.Web.Controllers
{
    public class PhoneBookController : PhonebookControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PhoneBookController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }
        public IActionResult Index(GetPeopleInput input)
        {
            var output = _personAppService.GetPeople(input);
            var model = new IndexViewModel();
            return View();
        }
    }
}