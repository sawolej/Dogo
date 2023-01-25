using Dogo.DB.BaseRepo;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class Dog: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Shelter { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public DateTime DataFrom { get; set; }


    }
}
