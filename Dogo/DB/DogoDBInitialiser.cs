using Dogo.Models;
using System.Data;

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
                if (!context.Shelter.Any())
               // {
                    context.Shelter.AddRange(new List<Shelter>(){
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
                         new Shelter()
                         {
                             ImageURL = "https://uml.lodz.pl/files/schronisko/public/SCHRONISKO_LOGO1.png",
                             Name = "Schronisko dla zwierząt w Łodzi",
                             Location = "Łódź",
                             Decsription = "desc 2"

                         },
                         new Shelter()
                         {
                             ImageURL = "https://www.schronisko-zwierzaki.lublin.pl/templates/bird/images/logo2.png",
                             Name = "Schronisko dla bezdomnych zwierząt w Lublinie",
                             Location = "Lublin",
                             Decsription = "desc 2"

                         },
                    });
                    context.SaveChanges();
                
                //dogs
                if (!context.Dog.Any())
                {
                    context.Dog.AddRange(new List<Dog>(){
                        new Dog()
                        {
                            ImageURL = "http://medor.endor.pl/sites/default/files/styles/medium/public/323703018_555806209794733_516473113210132684_n.jpg?itok=wZnmPDEb",
                            Name = "Azja",
                            Shelter = "Medor",
                            Age = 5,
                            Description ="desc 1",
                            DataFrom = new DateTime(2023, 01, 01),

                },
                         new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_202301/33470_20230121_095852_005.jpg",
                            Name = "Niedźwiadek",
                            Shelter = "Schronisko dla zwierząt w Łodzi",
                            Age = 0,
                            Description ="desc 1",
                            DataFrom = new DateTime(2023, 01, 21),

                },
                          new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_202207/31681_20220720_113427_001.jpg",
                            Name = "Tedi",
                            Shelter = "Schronisko dla zwierząt w Łodzi",
                            Age = 1,
                            Description ="desc 1",
                            DataFrom = new DateTime(2021, 10, 21),

                },
                           new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_201604/21338_20160406_191726_002.jpg",
                            Name = "Grześ",
                            Shelter = "Schronisko dla zwierząt w Łodzi",
                            Age = 8,
                            Description ="desc 1",
                            DataFrom = new DateTime(2015, 09, 29),

                },
                            new Dog()
                        {
                            ImageURL = "https://schronisko-lodz.pl/gfx/abase/abase_202210/33196_20221026_102802_002.jpg",
                            Name = "Lajla",
                            Shelter = "Schronisko dla zwierząt w Łodzi",
                            Age = 8,
                            Description ="desc 1",
                            DataFrom = new DateTime(2022, 10, 25),

                },
                            new Dog()
                        {
                            ImageURL = "https://foto1.napaluchu.waw.pl/reksio/scale/660/460/files/big/012200970/dc742f44f15c1450.jpg",
                            Name = "Stefan",
                            Shelter = "Schronisko na Paluchu",
                            Age = 1,
                            Description ="desc 1",
                            DataFrom = new DateTime(2022, 04, 25),

                },
                            new Dog()
                        {
                            ImageURL = "https://www.schronisko-zwierzaki.lublin.pl/components/com_djcatalog/images/f338023ab74156d590339232d2b7ec50Groszek4.jpg",
                            Name = "Groszka",
                            Shelter = "Schronisko dla bezdomnych zwierząt w Lublinie",
                            Age = 0,
                            Description ="desc 1",
                            DataFrom = new DateTime(2023, 01, 02),

                },
                            new Dog()
                        {
                            ImageURL = "https://foto1.napaluchu.waw.pl/reksio/scale/660/460/files/big/012200268/e4eff6686c8e5d7a.jpg",
                            Name = "Lajla",
                            Shelter = "Schronisko na Paluchu",
                            Age = 5,
                            Description ="desc 1",
                            DataFrom = new DateTime(2022, 01, 30),

                },
                    });
                    context.SaveChanges();
                }

         
            }
        }
    }
}
