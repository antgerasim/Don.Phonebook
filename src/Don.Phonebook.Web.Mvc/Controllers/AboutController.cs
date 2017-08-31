using Don.Phonebook.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Don.Phonebook.Web.Controllers
{
    public class AboutController : PhonebookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}