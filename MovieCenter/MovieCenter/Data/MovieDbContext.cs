using Microsoft.EntityFrameworkCore;
using MovieCenter.Models.Domain;
namespace MovieCenter.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
    }
}
