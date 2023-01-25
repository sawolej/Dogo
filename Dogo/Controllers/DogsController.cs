using Dogo.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Dogo.Controllers
{
    public class DogsController : Controller
    {
        private readonly DogoDBContext _context;

        public DogsController(DogoDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allDogs = await _context.Dog.ToListAsync();
            return View(allDogs);
        }
    }
}
