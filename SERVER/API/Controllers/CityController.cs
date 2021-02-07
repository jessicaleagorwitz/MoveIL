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

        [Route("addCity"), HttpPost]
        public void AddCity(CityDTO com)
        {
            BL.CityBL.AddCity(com);
        }

        

        [Route("getShowCity"), HttpGet]
        public IHttpActionResult getShowCity()

        {

            return Ok(BL.CityBL.getShowCity());
        }

        [Route("getYourCity"), HttpPost]
        public IHttpActionResult getYourCity([FromBody]int cityCode)

        {
            return Ok(BL.CityBL.getYourCity(cityCode));
        }


        [Route("getSearchCity"), HttpPost]
        public IHttpActionResult getSearchCity(CityStatusDTO c)
        {
            return Ok(BL.CityBL.getSearchCity(c));
        }

    }
}
