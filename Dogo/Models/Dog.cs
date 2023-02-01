//using Dogo.DB.BaseRepo;
using Dogo.DB.enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dogo.Models
{
    public class Dog//: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public DateTime DataFrom { get; set; }

        public DogBreed DogBreed { get; set; }
        [Display(Name = "Shelter")]
        public int ShelterId { get; set; }
        [ForeignKey ("ShelterId")]
        public Shelter Shelter { get; set; }
    }
}
