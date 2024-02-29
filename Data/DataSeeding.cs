using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app) 
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieContext>();

            context.Database.Migrate();

            if(context.Database.GetPendingMigrations().Count() == 0) 
            {
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(
                        new List<Movie>() {
                        new Movie{
                            Title = "Territory", 
                            Description = "Cox gozel film", 
                            ImageUrl="1.jpg", 
                            GenreId= 1},
                        new Movie{
                            Title = "Leo Di Film", 
                            Description = "Cox aglamali film", 
                            ImageUrl="2.jpg", 
                            GenreId= 1},
                        new Movie{
                            Title = "Hangover", 
                            Description = "Cox pis film", 
                            ImageUrl="3.jpg", 
                            GenreId= 1},
                         new Movie{
                            Title = "Territory", 
                            Description = "Cox gozel film", 
                            ImageUrl="4.jpg", 
                            GenreId= 3},
                        new Movie{
                            Title = "Hudson and Rex", 
                            Description = "Cox aglamali film", 
                            ImageUrl="5.jpg", 
                            GenreId= 3},
                        new Movie{
                            Title = "Hangover 2", 
                            Description = "Cox pis film", 
                            ImageUrl="6.jpg", 
                            GenreId= 4}
                        }
                        
                    );
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange
                    (
                    new List<Genre>()
                    {
                        new Genre{Name = "Detectiv"},
                        new Genre{Name = "Comedy"},
                        new Genre{Name = "Romantic"},
                        new Genre{Name = "War"}
                    }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
