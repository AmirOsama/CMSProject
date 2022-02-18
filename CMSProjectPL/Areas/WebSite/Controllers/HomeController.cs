using Microsoft.AspNetCore.Mvc;

namespace CMSProjectPL.Areas.WebSite.Controllers
{
    public class HomeController : Controller
    {
        [Area("WebSite")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
