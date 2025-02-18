using Microsoft.EntityFrameworkCore;

namespace Mission06_Hudgins.Models;

public class moviesContext : DbContext
{
    public moviesContext(DbContextOptions<moviesContext> options) : base(options)
    {
    }
    public DbSet<movies> movies { get; set; }
}