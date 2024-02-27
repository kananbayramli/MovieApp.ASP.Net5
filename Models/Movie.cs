using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Director { get; set; }

        public string[] Acters { get; set; }

        [Display(Name ="Image")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Filmin Kateqoriyasini secin...")]
        [Display(Name = "Category")]
        public int? GenreId { get; set; }  //null olduqda required ishleyir
    }
}
