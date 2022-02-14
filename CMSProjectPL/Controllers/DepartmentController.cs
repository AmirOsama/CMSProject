using Microsoft.AspNetCore.Mvc;

namespace CMSProjectPL.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
