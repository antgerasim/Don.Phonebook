using Don.Phonebook.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Don.Phonebook.Web.Host.Controllers
{
    public class AntiForgeryController : PhonebookControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}