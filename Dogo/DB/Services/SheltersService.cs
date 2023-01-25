using Dogo.DB.BaseRepo;
using Dogo.Models;

namespace Dogo.DB.Services
{
    public class SheltersService:EntityBaseRepo<Shelter>, IShelterService
    {
        public SheltersService(DogoDBContext context) : base(context)
        {

        }
    }
}
