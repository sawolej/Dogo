using Dogo.DB.BaseRepo;
using Dogo.DB;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class NewDogVM
    {


        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Shelter")]
        [Required(ErrorMessage = "Shelter is required")]
        public string Shelter { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

 /*       [Display(Name = "ShelterId")]
        [Required(ErrorMessage = "ShelterId is required")]
        public int ShelterId { get; set; }*/

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "In shelter from: ")]
        [Required(ErrorMessage = "Data From is required")]
        public DateTime DataFrom { get; set; }


    }
}
