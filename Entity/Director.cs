using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Entity
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Biography { get; set; }
    }
}
