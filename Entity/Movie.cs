﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Entity
{
    public class Movie
    {

        public Movie()
        {
            Genres = new List<Genre>();
        }


        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None)] MovieIdnin automatik artirilmasinin qarwisini alir. MsSql bunu automatik artirir.Artirilmasini istemedikde bele ede bilirik.
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageUrl { get; set; }


        public List<Genre> Genres { get; set; }
    }
}
