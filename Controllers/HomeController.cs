using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomePageViewModel 
            {
               PopularMovies =  MovieRepository.Movies
            };
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
