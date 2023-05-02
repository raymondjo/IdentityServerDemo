using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Movies.API.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.API.Models.Movie> Movie { get; set; }
    }
}