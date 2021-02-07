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
    [RoutePrefix("api/Contacts")]
    public class ContactsController : ApiController
    {
        [Route("getNumComunityContacts")]
        [HttpGet]
        public IHttpActionResult getContacts()
        {
          
            return Ok(1);
        }
        [Route("AddContacts"), HttpPost]
        public IHttpActionResult AddContacts(ContactDTO com)
        {
            BL.ContactBL.AddContacts(com);
            return Ok(true);
        }
        [Route("getShowContacts")]
        [HttpGet]
        public IHttpActionResult getShowContacts()
        
        {
           
            return Ok(BL.ContactBL.getShowContacts());
        }

        [Route("getContacts"), HttpPost]
        public IHttpActionResult getContact([FromBody]int cityCode)

        {
            // int x = 0;

            // Int32.TryParse(cityCode, out x);
            return Ok(BL.ContactBL.getContact(cityCode));
        }


    }
}
