using Dogo.DB;
using Dogo.DB.Services;
using Dogo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Dogo.Controllers
{
    public class DogsController : Controller
    {
        //private readonly DogoDBContext _context;
        private readonly IDogService _service;

        public DogsController(IDogService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allDogs = await _service.GetAllAsync();
            return View(allDogs);
        }

        //GET: /Details/1
        //[AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetDogByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {

            ViewData["Welcome"] = "wof!";
            ViewBag.Description = "hi there";



            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewDogVM dog)
        {
            if (!ModelState.IsValid)
            {
                return View(dog);
            }

            await _service.AddNewDogAsync(dog);
            return RedirectToAction(nameof(Index));
        }

        //GET: /Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var dogDetails = await _service.GetDogByIdAsync(id);
            if (dogDetails == null) return View("NotFound");

            var response = new NewDogVM()
            {
                Id = dogDetails.Id,
                Name = dogDetails.Name,
                Description = dogDetails.Description,
                Age = dogDetails.Age,
                DataFrom = dogDetails.DataFrom,               
                ImageURL = dogDetails.ImageURL,
                Shelter = dogDetails.Shelter
                
            };

          
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewDogVM dog)
        {
            if (id != dog.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
              

                return View(dog);
            }

            await _service.UpdateDogAsync(dog);
            return RedirectToAction(nameof(Index));
        }

        /*
           [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allMovies.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allMovies);
        }

  

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

            return View();
        }

       


        
         */
    }
}
