using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }

        public Dog Dog { get; set; }
        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}
