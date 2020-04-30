using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApi.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string ReleaseDate { get; set; }

        public string GenreName { get; set; }

        public string ActorName { get; set; }
    }
}