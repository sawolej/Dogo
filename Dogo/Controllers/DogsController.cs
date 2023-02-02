using Dogo.DB;
using Dogo.DB.Services;
//using Dogo.DB.Services;
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
        private readonly IDogService _service;

        public DogsController(IDogService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allDogs = await _service.GetAllAsync(n=>n.Shelter);
            return View(allDogs);
        }
        /*  
          

          //GET: /Details/1
          //[AllowAnonymous]
          public async Task<IActionResult> Details(int id)
          {
              var movieDetail = await _service.GetDogByIdAsync(id);
              return View(movieDetail);
          }


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
          public async Task<IActionResult> Filter(string searchString)
          {
              var allDogs = await _service.GetAllAsync();

              if (!string.IsNullOrEmpty(searchString))
              {

                  var filteredResultNew = allDogs.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                  return View("Index", filteredResultNew);
              }

              return View("Index", allDogs);
          }*/


    }
}
