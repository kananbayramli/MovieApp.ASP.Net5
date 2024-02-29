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
                            MovieId = 1 , 
                            Title = "Territory", 
                            Description = "Cox gozel film", 
                            Director = "Fred", 
                            ImageUrl="1.jpg", 
                            GenreId= 1},
                        new Movie{
                            MovieId = 2 ,
                            Title = "Leo Di Film", 
                            Description = "Cox aglamali film", 
                            Director = "Jonathan",
                            ImageUrl="2.jpg", 
                            GenreId= 1},
                        new Movie{
                            MovieId = 3 ,
                            Title = "Hangover", 
                            Description = "Cox pis film", 
                            Director = "Maykl",  
                            ImageUrl="3.jpg", 
                            GenreId= 1},
                         new Movie{
                            MovieId = 4 , 
                            Title = "Territory", 
                            Description = "Cox gozel film", 
                            Director = "Fred", 
                            ImageUrl="4.jpg", 
                            GenreId= 3},
                        new Movie{
                            MovieId = 5 ,
                            Title = "Hudson and Rex", 
                            Description = "Cox aglamali film", 
                            Director = "Jonathan", 
                            ImageUrl="5.jpg", 
                            GenreId= 3},
                        new Movie{MovieId = 6 ,
                            Title = "Hangover 2", 
                            Description = "Cox pis film", 
                            Director = "Maykl",  
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
                        new Genre{GenreId = 1, Name = "Detectiv"},
                        new Genre{GenreId = 2, Name = "Comedy"},
                        new Genre{GenreId = 3, Name = "Romantic"},
                        new Genre{GenreId = 4, Name = "War"}
                    }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
