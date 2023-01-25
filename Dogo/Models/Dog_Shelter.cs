namespace Dogo.Models
{
    public class Dog_Shelter
    {
        public int DogId { get; set; }
        public Dog Dog { get; set; }

        public int ShelterId { get; set; }
        public Shelter Shelter { get; set; }
    }
}
