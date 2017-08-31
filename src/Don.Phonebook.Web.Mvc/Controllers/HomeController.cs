using Abp.AspNetCore.Mvc.Authorization;
using Don.Phonebook.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Don.Phonebook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhonebookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}