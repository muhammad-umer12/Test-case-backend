using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Genres
    {
        public int Id { get; set; }

        public string GenreName { get; set; }
        public int MoviesId { get; set; }
    }
}
