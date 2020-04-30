using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        MoviesController()
        {
             
        }
       
        [HttpGet]
        public ActionResult Get()
        {
            Movies numbers2 = new List<Movies>()
        {
            new Movies{ Id=1 , MovieName="Rox" , ReleaseDate="06/06/2019"  },
            new Movies{ Id=2 , MovieName="War" , ReleaseDate="06/06/2019"  },
            new Movies{ Id=1 , MovieName="herapheri" , ReleaseDate="06/06/2019"  },
            new Movies{ Id=1 , MovieName="Rox" , ReleaseDate="06/06/2019"  },

        };
            Movies nm = new Movies()
            {
                Id = 1,
                MovieName = "Rox",
                ReleaseDate = "06/06/2019"
            };

            return numbers2;
        }
    }
}