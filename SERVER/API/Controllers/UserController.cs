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
    [RoutePrefix("api/user")]

    public class UserController : ApiController
    {
        [Route("AddUser"), HttpPost]
        public IHttpActionResult AddUser(UserDTO com)
        {
            BL.UserBL.AddUser(com);
           return Ok(true);
        }
    }
}
