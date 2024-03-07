using MovieApp.Web.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class AdminGenresViewModel
    {
        [Required(ErrorMessage ="Kateqoriya adini daxil edin!")]
        public string Name { get; set; }
        public List<AdminGenreViewModel> Genres { get; set; }
    }

    public class AdminGenreViewModel
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class AdminGenreEditViewModel 
    {
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<AdminMovieViewModel> Movies { get; set; }
    }
}
