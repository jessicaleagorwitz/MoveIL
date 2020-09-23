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
    //este es el nombre q le damos para poder llegar a el
    [RoutePrefix("api/comunityContacts")]
    public class ComunityContactsController : ApiController
    {
        [Route("getNumComunityContacts")]
        [HttpGet]
        public IHttpActionResult getNumComunityContacts()
        {
            return Ok(1);
        }
        [Route("AddComunityContacts"), HttpPost]
        public IHttpActionResult AddComunityContacts(ComunityContactsDTO com)
        {
            BL.ComunityContactsBL.AddComunityContacts(com);
            return Ok(true);
        }
        [Route("getShowComunityContacts")]
        [HttpGet]
        public IHttpActionResult getShowComunityContacts()
        
        {
            return Ok();
        }

    }
}
