using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Entity
{
    public class Cast  //acters
    {
        public int CastId { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }


        public Movie Movie { get; set; }
        public int MovieId { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
