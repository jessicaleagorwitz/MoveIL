using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{ [EnableCors("*", "*", "*")]
        [RoutePrefix("api/Sector")]

    public class SectorController : ApiController
    {
       
       
        //[Route("Sector"), HttpGet]
        //public IHttpActionResult Sector()
        //{
        //    BL.SectorBL.Sector();
        //    return Ok(true);
        //}
        

    }
}
