using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SkateSpotsFinalProject.Models;

namespace SkateSpotsFinalProject.Controllers
{
    public class SearchApiController : ApiController
    {


        ApplicationDbContext db = new ApplicationDbContext();
        //Will Search Description of SkateSpots and return results.

        // POST: api/SearchApi

        /// <summary>/// Post method takes in a search view model and returns SkateSpots
        /// </summary>
        /// <param name="search"> {"Term": ""} </param>
        /// <returns></returns>
        /// 
        public IEnumerable<SkateSpot> Post(SearchViewModel search)
        {
            return db.SkateSpots.Where(p => p.Description.Contains(search.Term));
        }
    }
}
