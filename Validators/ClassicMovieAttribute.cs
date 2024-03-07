using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Validators
{
    public class ClassicMovieAttribute : ValidationAttribute
    {
        public ClassicMovieAttribute(int year) //1950 modelden gelir
        {
            Year = year;
        }
        public int Year { get; set; }



        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (AdminCreateMovieModel)validationContext.ObjectInstance;
            var releaseYear = ((DateTime)value).Year;

            if (movie.IsClassic && releaseYear > Year)
            {
                return new ValidationResult($"Classic film ucun {Year} ve daha evvelki tarix daxil edin..");
            }
            return ValidationResult.Success;
        }
    }
}
