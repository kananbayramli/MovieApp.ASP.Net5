using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Acters { get; set; }
        public string ImageUrl { get; set; }
    }
}
