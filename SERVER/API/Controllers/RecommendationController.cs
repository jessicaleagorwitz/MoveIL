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
    [RoutePrefix("api/recommendation")]
    public class RecommendationController : ApiController
    {
        [Route("getShowRecommendation"), HttpGet]
        public IHttpActionResult getShowCity()

        {
            return Ok(BL.RecommendationBL.getShowRecommendation());
        }
        [Route("addRecommendation"), HttpPost]
        public IHttpActionResult addRecommendation(RecommendationDTO rec)
        {

            return Ok(BL.RecommendationBL.AddRecommendation(rec));
        }
    }
}
