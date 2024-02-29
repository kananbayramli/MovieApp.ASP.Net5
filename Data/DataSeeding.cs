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

            var genres = new List<Genre>()
                    {
                        new Genre{Name = "Detectiv", Movies= new List<Movie>(){
                            new Movie{
                            Title = "Genreden elave olunan detevtiv film",
                            Description = "Cox gozel film",
                            ImageUrl="1.jpg",
                            },
                        new Movie{
                            Title = "Genreden elave olunan detevtiv film 2",
                            Description = "Cox fbi film",
                            ImageUrl="6.jpg",
                            }}},

                        new Genre{Name = "Comedy"},
                        new Genre{Name = "Romantic"},
                        new Genre{Name = "War"}
                    };
            var movies = new List<Movie>() {
                        new Movie{
                            Title = "Territory",
                            Description = "Cox gozel film",
                            ImageUrl="1.jpg",
                            Genre= genres[0]},
                        new Movie{
                            Title = "Leo Di Film",
                            Description = "Cox aglamali film",
                            ImageUrl="2.jpg",
                            Genre= genres[1]},
                        new Movie{
                            Title = "Hangover",
                            Description = "Cox pis film",
                            ImageUrl="3.jpg",
                            Genre= genres[1]},
                         new Movie{
                            Title = "Roman",
                            Description = "Cox gozel film",
                            ImageUrl="4.jpg",
                            Genre= genres[2]},
                        new Movie{
                            Title = "Hudson and Rex",
                            Description = "Cox aglamali film",
                            ImageUrl="5.jpg",
                            Genre= genres[2]},
                        new Movie{
                            Title = "FBI 2",
                            Description = "Cox yaxwi film",
                            ImageUrl="6.jpg",
                            Genre= genres[3]}
                        };

            if (context.Database.GetPendingMigrations().Count() == 0) 
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }

                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(movies);
                }

                context.SaveChanges();
            }
        }
    }
}
