using MovieApp.Web.Entity;
using MovieApp.Web.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class AdminMoviesViewModel
    {
        public List<AdminMovieViewModel> Movies { get; set; }
    }

    public class AdminMovieViewModel 
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<Genre> Genres { get; set; }
    }

    public class AdminCreateMovieModel 
    {
        [Display(Name ="Film Name")]
        [Required(ErrorMessage ="Film adi mecburdur!")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Film adi ucun 3 - 50 araligda xarakter girilmelidir")]
        public string Title { get; set; }

        [Display(Name = "Film teferruati")]
        [Required(ErrorMessage = "Film teferruati mecburdur!")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Film teferruati ucun 10 - 3000 araligda xarakter girilmelidir")]
        public string Description { get; set; }
        [Required(ErrorMessage = "En az bir kateqoriya secilmelidir!")]
        public int[] GenreIds { get; set; }

        //Custom Validation example
        public bool IsClassic { get; set; }

        [ClassicMovie(1950)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }


    public class AdminEditMovieViewModel
    {
        public int MovieId { get; set; }
        [Display(Name = "Film Name")]
        [Required(ErrorMessage = "Film adi mecburdur!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Film adi ucun 3 - 50 araligda xarakter girilmelidir")]
        public string Title { get; set; }

        [Display(Name = "Film teferruati")]
        [Required(ErrorMessage = "Film teferruati mecburdur!")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Film teferruati ucun 10 - 3000 araligda xarakter girilmelidir")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "En az bir kateqoriya secilmelidir!")]
        public int[] GenreIds { get; set; }
    }
}
