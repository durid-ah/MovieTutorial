using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The RM",
                         ReleaseDate = DateTime.Parse("2003-9-11"),
                         Genre = "Comedy",
                         Price = 9.99M,
                         Rating = "PG"

                     },

                     new Movie
                     {
                         Title = "Best Two Years",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating = "PG"
                     },

                     new Movie
                     {
                         Title = "Home Teachers",
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Price = 4.99M,
                         Rating = "PG"
                     },

                   new Movie
                   {
                       Title = "Church Ball",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = "Comedy",
                       Price = 3.99M,
                       Rating = "PG"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}