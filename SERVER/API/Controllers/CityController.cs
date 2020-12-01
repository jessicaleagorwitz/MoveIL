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
        [RoutePrefix("api/City")]
    public class CityController : ApiController
    {
       

        public void AddCity(CityDTO com)
        {
            BL.CityBL.AddCity(com);
        }

        //[Route("City"), HttpGet]
        //public IHttpActionResult City()
        //{
        //    BL.CityBL.City();
        //    return Ok(true);
        //}

        [Route("getShowCity"), HttpGet]
        public IHttpActionResult getShowCity()

        {

            return Ok(BL.CityBL.getShowCity());
        }
    }
}
