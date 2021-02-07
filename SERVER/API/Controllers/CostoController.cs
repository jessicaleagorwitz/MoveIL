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
    [RoutePrefix("api/costo")]

    public class CostoController : ApiController
    {
        [Route("AddCountry"), HttpPost]
        public IHttpActionResult AddCountry(CostoDTO com)
        {
            BL.CostoBL.AddCosto(com);
            return Ok();
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
