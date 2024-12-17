using Microsoft.AspNetCore.Mvc;

namespace PW1_RPM.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        public IActionResult Index()
        {
            // Страница политики конфиденциальности
            return View();
        }
    }
}
