using Microsoft.AspNetCore.Mvc;

namespace CMSProjectPL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
