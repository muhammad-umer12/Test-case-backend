using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public string ActorName { get; set; }

        public int MoviesId { get; set; }
    }
}
