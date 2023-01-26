using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class OrderSnack
    {
        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }
        public double Price { get; set; }

        public int DogId { get; set; }
        [ForeignKey("DogId")]
        public Dog Dog { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Snack Order { get; set; }
    }
}
