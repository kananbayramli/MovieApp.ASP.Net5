using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
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

        public IActionResult List(int? id)
        {
            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(m => m.GenreId == id).ToList();
            }

            var model = new MoviesViewModel
            {
                Movies = movies
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {      
            return View(MovieRepository.GetById(id));
        }
    }
}
