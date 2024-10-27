using Microsoft.AspNetCore.Mvc;

namespace GitManagementTest.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var message = "This is Product View";
            return View();
        }
    }
}
