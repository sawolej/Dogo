using Dogo.Models;
using System.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dogo.DB.enums;

namespace Dogo.DB
{
    public class DogoDBInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DogoDBContext>();

                context.Database.EnsureCreated();

                //shelter
                if (!context.Shelters.Any())
                {
                    context.Shelters.AddRange(new List<Shelter>(){
                        new Shelter()
                        {
                            ImageURL = "http://medor.org/sites/default/files/medor_0.jpg",
                            Name = "Medor",
                            Location = "Zgierz",
                            Decsription ="desc 1"

                        },
                         new Shelter()
                         {
                             ImageURL = "https://napaluchu.waw.pl/wp-content/themes/paluch/images/logo-1.png",
                             Name = "Na Paluchu",
                             Location = "Warszawa",
                             Decsription = "desc 2"

                         },
            
                    });
                    context.SaveChanges();
                }
                //dogs
                if (!context.Dogs.Any())
                {
                    context.Dogs.AddRange(new List<Dog>(){
                        new Dog()
                        {
                            ImageURL = "http://medor.endor.pl/sites/default/files/styles/medium/public/323703018_555806209794733_516473113210132684_n.jpg?itok=wZnmPDEb",
                            Name = "Azja",
                            Age = 5,
                            Description ="desc",
                            DataFrom = new DateTime(2023, 01, 01),
                            DogBreed = DogBreed.None,
                            ShelterId =1

                },
                         new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_202301/33470_20230121_095852_005.jpg",
                            Name = "Niedźwiadek",
                            Age = 0,
                            Description ="desc 1",
                            DataFrom = new DateTime(2023, 01, 21),
                            DogBreed = DogBreed.None,
                            ShelterId =1

                },
                          new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_202207/31681_20220720_113427_001.jpg",
                            Name = "Tedi",
                            Age = 1,
                            Description ="desc 1",
                            DataFrom = new DateTime(2021, 10, 21),
                            DogBreed = DogBreed.None,
                            ShelterId =1

                },
                           new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_201604/21338_20160406_191726_002.jpg",
                            Name = "Grześ",
                            Age = 8,
                            Description ="desc 1",
                            DataFrom = new DateTime(2015, 09, 29),
                            DogBreed = DogBreed.None,
                            ShelterId =1

                },
                            new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_202210/33196_20221026_102802_002.jpg",
                            Name = "Lajla",
                            Age = 8,
                            Description ="desc 1",
                            DataFrom = new DateTime(2022, 10, 25),
                            DogBreed = DogBreed.None,
                            ShelterId =1

                },
                            new Dog()
                        {
                            ImageURL = "https://foto1.napaluchu.waw.pl/reksio/scale/660/460/files/big/012200970/dc742f44f15c1450.jpg",
                            Name = "Stefan",
                            Age = 1,
                            Description ="desc 1",
                            DataFrom = new DateTime(2022, 04, 25),
                            DogBreed = DogBreed.None,
                            ShelterId =1

                },
                            new Dog()
                        {
                            ImageURL = "https://www.schronisko-zwierzaki.lublin.pl/components/com_djcatalog/images/f338023ab74156d590339232d2b7ec50Groszek4.jpg",
                            Name = "Groszka",
                            Age = 0,
                            Description ="desc 1",
                            DataFrom = new DateTime(2023, 01, 02),
                            DogBreed = DogBreed.None,
                            ShelterId =1

                },

                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
