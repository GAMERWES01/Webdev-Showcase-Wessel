using Microsoft.AspNetCore.Mvc;

namespace Showcase_Profielpagina.Controllers
{
    public class DamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
