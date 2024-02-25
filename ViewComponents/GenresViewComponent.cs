using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var tipLists = new List<Genre>() {
                new Genre{ Name = "Detectiv"},
                new Genre{ Name = "Comedy"},
                new Genre{ Name = "Romantic"},
                new Genre{ Name = "War"},
            };
            return View(tipLists);
        }
    }
}
