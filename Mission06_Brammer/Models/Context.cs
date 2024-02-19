using Microsoft.EntityFrameworkCore;

namespace Mission06_Brammer.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) 
        { 
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed Data
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Drama" },
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Mystery" },
                new Category { CategoryId = 4, CategoryName = "Soap" },
                new Category { CategoryId = 5, CategoryName = "Anime" }

                );
        }
    }
}
