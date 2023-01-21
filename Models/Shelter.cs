using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class Shelter
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Shelter Logo")]
        public string ImageURL { get; set; }
        [Display(Name = "Shelter Name")]
        public string Name { get; set; }
        [Display(Name = "Shelter Location")]
        public string Location { get; set; }
        [Display(Name = "Shelter Description")]
        public string Decsription { get; set; }

        //Relationship

        public List<Dog> Dogs { get; set; }
    }
}
