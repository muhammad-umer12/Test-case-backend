using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesApi.Models;

namespace MoviesApi.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult  Index()
        {
            IList<Movies> numbers = new List<Movies>()
        {
            new Movies{ Id=1 , MovieName="War" , GenreName="Action" ,ReleaseDate="06/06/2019"  , ActorName="Hirtik Roshan"},
            new Movies{ Id=2 , MovieName="Fast 5" ,GenreName="Action", ReleaseDate="06/06/2019",   ActorName="Paul walker" },
            new Movies{ Id=3 , MovieName="Mr Bean" , GenreName="Comedy",ReleaseDate="06/06/2019", ActorName="Rowan Atkinson"  },
            new Movies{ Id=4 , MovieName="One body and soul" ,GenreName="drama" ,ReleaseDate="06/06/2017", ActorName="Rowan Atkinson"  },

        };

          

            return View(numbers);
        }
    }
}