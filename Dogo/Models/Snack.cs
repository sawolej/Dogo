using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dogo.Models
{
    public class Snack
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
       // public ApplicationUser User { get; set; }

        public List<OrderSnack> OrderItems { get; set; }
    }
}
