using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/country")]

    public class CountryController : ApiController
    {
        [Route("AddCountry"), HttpPost]
        public IHttpActionResult AddCountry(CountryDTO com)
        {
            BL.CountryBL.AddCountry(com);
            return Ok();
        }
        [Route("getShowCountry")]
        [HttpGet]
        public IHttpActionResult getShowCountry()

        {
            BL.CountryBL.getShowCountry();
            return Ok(true);
        }
        //[Route("Country")]
        //[HttpGet]
        //public IHttpActionResult country()
        //{
        //    BL.CountryBL.AddCountries();
        //    return Ok(true);
            
        //}
       
    }
}
