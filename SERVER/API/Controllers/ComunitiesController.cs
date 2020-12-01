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
    [EnableCors("*","*","*")]
    //este es el nombre q le damos para poder llegar a el
    [RoutePrefix("api/comunities")]
    public class ComunitiesController : ApiController
    {//esta es tipo get , get es brerat mejdal
        [Route("getNumComunities")]
        [HttpGet]
        public IHttpActionResult getNumComunities()
        {
            return Ok(1);
        }
        //asi para recibir parametrim
      //  [Route("b/{ComunityCode}")]
       // public int b(int code)
       // {
       //     return code;
      //  }
        //tipo post
        [Route(" AddComunity"), HttpPost]
        public IHttpActionResult AddComunity(ComunityDTO com)
        {
            BL.ComunityBL.AddComunity(com);
            return Ok(true);
        }

        //[Route("Comunity"), HttpGet]
        //public IHttpActionResult Comunity()
        //{
        //    BL.ComunityBL.Comunity();
        //    return Ok(true);
        //}

    }
}
