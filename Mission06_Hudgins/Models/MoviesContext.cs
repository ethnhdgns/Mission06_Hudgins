using Microsoft.EntityFrameworkCore;

namespace Mission06_Hudgins.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<CategoryID> CategoryIds { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasNoKey(); // Make the entity keyless
        }

    }
}