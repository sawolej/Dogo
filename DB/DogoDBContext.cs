using Dogo.Models;
using Microsoft.EntityFrameworkCore;

namespace Dogo.DB
{
    public class DogoDBContext:DbContext
    {
        public DogoDBContext(DbContextOptions  <DogoDBContext> options)   : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog_Shelter>().HasKey(ds => new
            {
                ds.DogId,
                ds.ShelterId
            });
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dog> Dog { get; set; }
        public DbSet<Dog_Shelter> Dog_Shelter { get; set; }
        public DbSet<Shelter> Shelter { get; set; }

    }
}
