using Dogo.DB.BaseRepo;

using Dogo.Models;
using System;

namespace Dogo.DB.Services
{
    public interface IDogService:IEntityBaseRepo<Dog>
    {
        Task<Dog> GetDogByIdAsync(int id);

        /*  Task AddNewMovieAsync(NewMovieVM data);
         Task UpdateMovieAsync(NewMovieVM data);*/
    }
}
