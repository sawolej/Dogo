using Dogo.Models;

namespace Dogo.DB.ViewModels
{
    public class NewDogDropdownsVM
    {
        public NewDogDropdownsVM()
        {
            Shelters = new List<Shelter>();
            
        }

        public List<Shelter> Shelters { get; set; }
    
    }
}
