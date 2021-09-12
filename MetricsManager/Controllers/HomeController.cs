using Microsoft.AspNetCore.Mvc;

namespace MetricsManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
