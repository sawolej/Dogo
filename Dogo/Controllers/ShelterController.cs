using Dogo.DB;
//using Dogo.DB.Services;
using Dogo.Models;
using Microsoft.AspNetCore.Authorization;
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
            var allShelters = await _context.Shelters.ToListAsync();
            return View(allShelters);
        }


        /*
        private readonly IShelterService _service;

        public ShelterController(IShelterService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allShelters = await _service.GetAllAsync();
            return View(allShelters);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("logo, Name, Description")] Shelter shelter)
        {
            if (!ModelState.IsValid) { return View(shelter); }
            await _service.AddAsync(shelter);
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var shelterDetails = await _service.GetByIdAsync(id);
            if (shelterDetails == null) return View("NotFound");
            return View(shelterDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var shelterDetails = await _service.GetByIdAsync(id);
            if (shelterDetails == null) return View("NotFound");
            return View(shelterDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageURL,Name, Location,Decsription")] Shelter shelter)
        {
            if (!ModelState.IsValid) return View(shelter);
            await _service.UpdateAsync(id, shelter);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var shelterDetails = await _service.GetByIdAsync(id);
            if (shelterDetails == null) return View("NotFound");
            return View(shelterDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var shelterDetails = await _service.GetByIdAsync(id);
            if (shelterDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

*/

    }
}
