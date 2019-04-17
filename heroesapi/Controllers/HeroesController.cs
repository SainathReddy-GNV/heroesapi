using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace heroesapi.Controllers
{
    public class HeroesController : ApiController
    {
        [HttpGet]
        [Route(("~/api/heroes/GetHeroes"))]
        public IEnumerable<string> GetHeroes()
        {
            return new string[] { "AntMan", "BatMan", "SuperMan", "IronMan" };
        }
    }
}
