using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using MoviesDockerDemo.Models;

namespace MoviesDockerDemo.Data
{
    public class Seeder
    {
        public static void SeedDatabase(IServiceProvider serviceProvider)
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    DirectorName = "James Cameron",
                    Genre = "Action",
                    Name = "Avatar",
                    ReleaseYear = "2009"
                },
                new Movie
                {
                    DirectorName = "Lee Tamahori",
                    Genre = "Action, Suspense",
                    Name = "Die Another Day",
                    ReleaseYear = "2002"
                },
                new Movie
                {
                    DirectorName = "Gareth Edwards",
                    Genre = "Fiction, Science",
                    Name = "Godzilla",
                    ReleaseYear = "2014"
                }
            };
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MovieContext>();

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(movies);
                    context.SaveChanges();
                }

                
            }
        }
    }
}
