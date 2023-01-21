using Dogo.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dogo.Controllers
{
    public class ShelterController : Controller
    {
        private readonly DogoDBContext _context;

        public ShelterController(DogoDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allShelters = await _context.Shelter.ToListAsync();
            return View(allShelters);
        }
     
    }
}
