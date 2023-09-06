using Microsoft.EntityFrameworkCore;

namespace MovieListMiles.Models
{
    public class MovieContext : DBContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(){

                new Movie
                {
                    MovieID = 1,
                    Name = "Casablanca",
                    Year = 1942,
                    Rating = 5
                },
                  new Movie
                  {
                      MovieID = 2,
                      Name = "Wonder Woman",
                      Year = 2017,
                      Rating = 3
                  },
                    new Movie
                    {
                        MovieID = 3,
                        Name = "Moonstruck",
                        Year = 1988,
                        Rating = 4
                    }




            };
        }
    }
}
