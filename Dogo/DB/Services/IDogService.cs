using Dogo.DB.BaseRepo;

using Dogo.Models;
using System;

namespace Dogo.DB.Services
{
    public interface IDogService:IEntityBaseRepo<Dog>
    {
        Task<Dog> GetDogByIdAsync(int id);

        Task AddNewDogAsync(NewDogVM data);
         /*Task UpdateMovieAsync(NewMovieVM data);*/
    }
}
