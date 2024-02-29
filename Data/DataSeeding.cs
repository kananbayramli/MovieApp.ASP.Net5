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
            var users = new List<User>()
            {
                new User(){Username = "userA", Email="usera@gmail.com", Password="1234", ImageUrl="person1.jpg" },
                new User(){Username = "userB", Email="userb@gmail.com", Password="1234", ImageUrl="person2.jpg" },
                new User(){Username = "userC", Email="userc@gmail.com", Password="1234", ImageUrl="person3.jpg",
                        Person = new Person()
                        {
                            Name="Personal 1",
                            Biography="Tanitim 1"
                        }
                },

                new User(){Username = "userD", Email="userd@gmail.com", Password="1234", ImageUrl="person4.jpg",
                        Person = new Person()
                        {
                            Name="Personal 2",
                            Biography="Tanitim 2"
                        }
                }
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

                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(users);
                }

                context.SaveChanges();
            }
        }
    }
}
