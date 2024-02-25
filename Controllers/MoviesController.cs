using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var tipLists = new List<Genre>() {
                new Genre{ Name = "Detectiv"},
                new Genre{ Name = "Comedy"},
                new Genre{ Name = "Romantic"},
                new Genre{ Name = "War"},
            };

            var movies = new List<Movie>() { 
            new Movie{Title = "Comedy", Description = "Cox gozel film", Director = "Fred", Acters = new string[] {"Jonny Dep", "Brad Pit" }, ImageUrl="1.jpg"},
            new Movie{Title = "Drama", Description = "Cox aglamali film", Director = "Jonathan", Acters = new string[] {"Jonny Dep", "Brad Pit" },ImageUrl="2.jpg"},
            new Movie{Title = "Melodrama", Description = "Cox pis film", Director = "Maykl", Acters = new string[] {"Jonny Dep", "Brad Pit" }, ImageUrl="3.jpg"},
            };

            var model = new MovieGenreViewModel 
            {
                Movies = movies,
                Genres = tipLists
            };

            return View(model);
        }
    }
}
