using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class Shelter
    {
        [Key]
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Decsription { get; set; }

        //Relationship

        public List<Dog> Dogs { get; set; }
    }
}
