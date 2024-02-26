using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>() {
            new Movie{MovieId = 1 , Title = "Comedy", Description = "Cox gozel film", Director = "Fred", Acters = new string[] {"Jonny Dep", "Brad Pit" }, ImageUrl="1.jpg"},
            new Movie{MovieId = 2 ,Title = "Drama", Description = "Cox aglamali film", Director = "Jonathan", Acters = new string[] {"Jonny Dep", "Brad Pit" },ImageUrl="2.jpg"},
            new Movie{MovieId = 3 ,Title = "Melodrama", Description = "Cox pis film", Director = "Maykl", Acters = new string[] {"Jonny Dep", "Brad Pit" }, ImageUrl="3.jpg"},
             new Movie{MovieId = 4 , Title = "Comedy", Description = "Cox gozel film", Director = "Fred", Acters = new string[] {"Jonny Dep", "Brad Pit" }, ImageUrl="1.jpg"},
            new Movie{MovieId = 5 ,Title = "Drama", Description = "Cox aglamali film", Director = "Jonathan", Acters = new string[] {"Jonny Dep", "Brad Pit" },ImageUrl="2.jpg"},
            new Movie{MovieId = 6 ,Title = "Melodrama", Description = "Cox pis film", Director = "Maykl", Acters = new string[] {"Jonny Dep", "Brad Pit" }, ImageUrl="3.jpg"}
            };
        }

        public static List<Movie> Movies 
        {
            get 
            {
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);         
        }
    }
}
