using Microsoft.AspNetCore.Mvc;
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
            string FilmTitle = "film Bashligi";
            string FilmDescription = "Film Achiqlamasi";
            string FilmDirector = "Fred Quimby";
            string[] acters = {"Tom", "Jerry", "Duffy Duck" };

            var m = new Movie();
            m.Title = FilmTitle;
            m.Description = FilmDescription;
            m.Director = FilmDirector;
            m.Acters = acters;
            m.ImageUrl = "1.jpg";

            return View(m);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
