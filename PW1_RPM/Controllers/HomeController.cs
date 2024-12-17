using Microsoft.AspNetCore.Mvc;

namespace PW1_RPM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
