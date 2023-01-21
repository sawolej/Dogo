using Microsoft.AspNetCore.Mvc;

namespace Dogo.Controllers
{
    public class ShelterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
