using Microsoft.EntityFrameworkCore;

namespace Mission06_Brammer.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) 
        { 
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<CategoryM> Categories { get; set; }

       
    }
}
