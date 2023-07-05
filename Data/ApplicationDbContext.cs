using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

            
        }
        public DbSet<Catogery>catogeries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catogery>().HasData(
                new Catogery { Id = 1, Name = "Action", DisplayOrder =1},
                new Catogery { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Catogery { Id = 3, Name = "History", DisplayOrder = 3}
                );
        }
    }
}