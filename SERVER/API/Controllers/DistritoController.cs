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
    [RoutePrefix("api/Distrito")]
    public class DistritoController : ApiController
    {
        [Route("getDistrito"), HttpGet]
        public IHttpActionResult getDistrito()

        {
            return Ok(BL.DistritoBL.getDistrito());
        }

        [Route("getDistritoCode"), HttpPost]
        public IHttpActionResult getDistritoCode([FromBody]int  Code)

        {

            return Ok(BL.DistritoBL.getDistritoCode(Code));
        }

    }
}
