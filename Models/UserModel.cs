using MovieApp.Web.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [EmailProviders]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }  

        [Url]
        public string Url { get; set; }

        [BirthDate(ErrorMessage ="Dogum tarixi gelecek tarix ola bilmez!")]
        [DataType(DataType.Date)]
        [Display(Name="Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
