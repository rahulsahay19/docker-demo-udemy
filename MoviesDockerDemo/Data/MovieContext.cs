using Microsoft.EntityFrameworkCore;
using MoviesDockerDemo.Models;

namespace MoviesDockerDemo.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
