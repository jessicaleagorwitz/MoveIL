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
            
           return Ok(BL.UserBL.AddUser(com));
        }


        [Route("getUserCode"), HttpPost]
        public IHttpActionResult getUserCode([FromBody]int cityCode)

        {
 return Ok(BL.UserBL.getUserCode(cityCode));
        }



        [Route("SingInCheckUser"), HttpPost]
        public IHttpActionResult SingInCheckUser([FromBody]string mail)

        {
            return Ok(BL.UserBL.SingInCheckUser(mail));
        }

        [Route("LogIn"), HttpPost]
        public IHttpActionResult LogIn(LoginDTO log)
        {
          
          
            return Ok(BL.UserBL.LogIn(log));
        }
    }
}
