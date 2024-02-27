using MovieApp.Web.Entity;
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
            new Movie{MovieId = 1 , Title = "Territory", Description = "Cox gozel film", Director = "Fred", ImageUrl="1.jpg", GenreId= 1},
            new Movie{MovieId = 2 ,Title = "Leo Di Film", Description = "Cox aglamali film", Director = "Jonathan",ImageUrl="2.jpg", GenreId= 1},
            new Movie{MovieId = 3 ,Title = "Hangover", Description = "Cox pis film", Director = "Maykl",  ImageUrl="3.jpg", GenreId= 1},
             new Movie{MovieId = 4 , Title = "Territory", Description = "Cox gozel film", Director = "Fred", ImageUrl="1.jpg", GenreId= 3},
            new Movie{MovieId = 5 ,Title = "Leo Di Film", Description = "Cox aglamali film", Director = "Jonathan", ImageUrl="2.jpg", GenreId= 3},
            new Movie{MovieId = 6 ,Title = "Hangover 2", Description = "Cox pis film", Director = "Maykl",  ImageUrl="3.jpg", GenreId= 4}
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
            movie.MovieId = _movies.Count() + 1;
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);         
        }

        public static void Edit(Movie m) 
        {
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId)
                {
                    movie.Title = m.Title;
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.GenreId = m.GenreId;
                    movie.ImageUrl = m.ImageUrl;
                }
                break;
            }
            
        }

        public static void Delete(int MovieId) 
        {
            var movie = GetById(MovieId);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
        }
    }
}
