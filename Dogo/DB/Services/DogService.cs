using Dogo.DB.BaseRepo;
using Dogo.Models;
using Microsoft.EntityFrameworkCore;

namespace Dogo.DB.Services
{
    public class DogService:EntityBaseRepo<Dog>, IDogService
    {
        private readonly DogoDBContext _context;
        public DogService(DogoDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Dog> GetDogByIdAsync(int id)
        {
            var dogDetails = await _context.Dog.FirstOrDefaultAsync(n => n.Id == id);
            return dogDetails;
        }
        public async Task AddNewDogAsync(NewDogVM data)
        {
            var newDog = new Dog()
            {
                Name = data.Name,
                Description = data.Description,
                Age = data.Age,
                ImageURL = data.ImageURL,
                Shelter = data.Shelter,
                DataFrom = data.DataFrom               
            };
            await _context.Dog.AddAsync(newDog);
            await _context.SaveChangesAsync();
            
        }

        public async Task UpdateDogAsync(NewDogVM data)
        {
            var dbDog = await _context.Dog.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbDog != null)
            {
                dbDog.Name = data.Name;
                dbDog.Description = data.Description;
                dbDog.Age = data.Age;
                dbDog.ImageURL = data.ImageURL;
                dbDog.Shelter = data.Shelter;
                dbDog.DataFrom = data.DataFrom;
              
                await _context.SaveChangesAsync();
            }

           
        }

        /*        

                public async Task<Dog> GetDogByIdAsync(int id)
                {
                    var DogDetails = await _context.Dogs
                        .Include(c => c.Cinema)
                        .Include(p => p.Producer)
                        .Include(am => am.Actors_Dogs).ThenInclude(a => a.Actor)
                        .FirstOrDefaultAsync(n => n.Id == id);

                    return DogDetails;
                }

                public async Task<NewDogDropdownsVM> GetNewDogDropdownsValues()
                {
               
                }

               */
    }
}
