using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult List(int? id, string q)
        {
            //var query = HttpContext.Request.Query["q"].ToString(); queryStringi parametrden elave belede almag olar

            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(m => m.GenreId == id).ToList();
            }

            if(!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(m => 
                    m.Title.ToLower().Contains(q.ToLower()) ||
                    m.Description.ToLower().Contains(q.ToLower())
                ).ToList();
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


        public IActionResult Create() 
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if(ModelState.IsValid) 
            {
                MovieRepository.Add(m);
                return RedirectToAction("List");
            }
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(m);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new  SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(MovieRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Edit(m);
                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
            }

            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(m);
        }
    }
} 
