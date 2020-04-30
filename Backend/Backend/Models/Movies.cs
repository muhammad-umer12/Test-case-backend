using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string ReleaseDate { get; set; }

        public static implicit operator Movies(List<Movies> v)
        {
            throw new NotImplementedException();
        }
    }
}
