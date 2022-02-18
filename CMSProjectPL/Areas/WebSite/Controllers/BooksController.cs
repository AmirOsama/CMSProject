using Microsoft.AspNetCore.Mvc;

namespace CMSProjectPL.Areas.WebSite.Controllers
{
    public class BooksController : Controller
    {
        [Area("WebSite")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("WebSite")]
        public IActionResult BookDet()
        {
            return View();
        }
    }
}
