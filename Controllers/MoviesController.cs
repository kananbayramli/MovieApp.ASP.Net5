using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
