using Dogo.DB;
using Microsoft.AspNetCore.Mvc;

namespace Dogo.Controllers
{
    public class DogsController : Controller
    {
        private readonly DogoDBContext _context;

        public DogsController(DogoDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Dog.ToList();
            return View();
        }
    }
}
