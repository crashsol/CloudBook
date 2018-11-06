using Microsoft.AspNetCore.Antiforgery;
using CloudBook.Controllers;

namespace CloudBook.Web.Host.Controllers
{
    public class AntiForgeryController : CloudBookControllerBase
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
