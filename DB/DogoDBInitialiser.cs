using Dogo.Models;
using System.Data;

namespace Dogo.DB
{
    public class DogoDBInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DogoDBContext>();

                context.Database.EnsureCreated();

                //shelter
                if (!context.Shelter.Any())
                {
                    context.Shelter.AddRange(new List<Shelter>(){
                        new Shelter()
                        {
                            ImageURL = "http://medor.org/sites/default/files/medor_0.jpg",
                            Name = "shleter 1",
                            Location = "location 1",
                            Decsription ="desc 1"
                        
                        },
                         new Shelter()
                         {
                             ImageURL = "xxxx",
                             Name = "shleter 2",
                             Location = "location 2",
                             Decsription = "desc 2"

                         },
                    });
                    context.SaveChanges();
                }
                //dogs
                if (!context.Dog.Any())
                {
                    context.Dog.AddRange(new List<Dog>(){
                        new Dog()
                        {
                            ImageURL = "http://medor.org/sites/default/files/medor_0.jpg",
                            Name = "shleter 1",
                            Shelter = "location 1",
                            Age = 1,
                            Description ="desc 1",
                            DataFrom = new DateTime(2015, 12, 31),

                },
                         new Dog()
                        {
                            ImageURL = "http://medor.org/sites/default/files/medor_0.jpg",
                            Name = "shleter 1",
                            Shelter = "location 1",
                            Age = 1,
                            Description ="desc 1",
                            DataFrom = new DateTime(2015, 12, 31),

                },
                    });
                    context.SaveChanges();
                }

                //dog_shelter
                if (!context.Dog_Shelter.Any())
                {
                    context.Dog_Shelter.AddRange(new List<Dog_Shelter>(){
                        new Dog_Shelter()
                        {
                           DogId=1,
                           ShelterId=1

                        },
                         new Dog_Shelter()
                        {
                           DogId=2,
                           ShelterId=1

                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
