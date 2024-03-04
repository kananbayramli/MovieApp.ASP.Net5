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




        public IActionResult Index()
        {
            return View();
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
                    .Where(m => m.Genres.Any(g => g.GenreId==id));
            }

            if(!string.IsNullOrEmpty(q))
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


        public IActionResult Create() 
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if(ModelState.IsValid) 
            {
                //MovieRepository.Add(m);
                _context.Movies.Add(m);
                _context.SaveChanges();

                TempData["message"] = $"{m.Title} adli film elave olundu...";
                return RedirectToAction("List");
            }
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(m);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new  SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(_context.Movies.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                //MovieRepository.Edit(m);
                _context.Movies.Update(m);
                _context.SaveChanges();

                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
            }

            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(m);
        }


        [HttpPost]
        public IActionResult Delete(int MovieId, string Title) 
        {
            //MovieRepository.Delete(MovieId);
            var movie = _context.Movies.Find(MovieId);
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            TempData["message"] = $"{Title} adli film silinmishdir...";
            return RedirectToAction("List");
        }
    }
} 
