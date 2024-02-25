using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class MovieGenreViewModel
    {
        public List<Genre> Genres { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
