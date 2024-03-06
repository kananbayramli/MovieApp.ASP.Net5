using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }


        public IActionResult List(int? id, string q)
        {
            //var query = HttpContext.Request.Query["q"].ToString(); queryStringi parametrden elave belede almag olar

            //var movies = MovieRepository.Movies; Repodan
            var movies = _context.Movies.AsQueryable(); //Asqueryable elediyimiz ucun toliste filter zamani kecirmek lazim deyil, ish bitdikden sonra db-ye yollamaq olar

            if (id != null)
            {
                movies = movies
                    .Include(m => m.Genres)
                    .Where(m => m.Genres.Any(g => g.GenreId == id));
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(m =>
                    m.Title.ToLower().Contains(q.ToLower()) ||
                    m.Description.ToLower().Contains(q.ToLower())
                );
            }

            var model = new MoviesViewModel
            {
                Movies = movies.ToList()
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }


    }
} 
