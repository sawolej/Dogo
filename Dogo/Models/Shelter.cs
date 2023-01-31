//using Dogo.DB.BaseRepo;
using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class Shelter//:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Shelter Logo")]
        [Required(ErrorMessage ="Shelter logo is required")]
        public string ImageURL { get; set; }
        [Display(Name = "Shelter Name")]
        [Required(ErrorMessage = "Shelter Name is required")]
        public string Name { get; set; }
        [Display(Name = "Shelter Location")]
        [Required(ErrorMessage = "Shelter Location is required")]
        public string Location { get; set; }
        [Display(Name = "Shelter Description")]
        [Required(ErrorMessage = "Shelter Description is required")]
        public string Decsription { get; set; }

        //Relationship
        public List<Dog> Dogs { get; set; }
    }
}
