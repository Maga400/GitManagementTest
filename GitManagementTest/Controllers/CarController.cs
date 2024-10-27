using Microsoft.AspNetCore.Mvc;

namespace GitManagementTest.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
