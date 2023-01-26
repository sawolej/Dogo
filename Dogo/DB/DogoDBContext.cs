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
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dog> Dog { get; set; }
        public DbSet<Shelter> Shelter { get; set; }

    }
}
