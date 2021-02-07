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
       
        [Route("getComunities"), HttpPost]
        public IHttpActionResult getComunity(PersonalStatusDTO per)
        {
            return Ok(BL.ComunityBL.getComunity(per));
        }


     
        [Route("getYourComunity"), HttpPost]
        public IHttpActionResult getYourComunity([FromBody]int code)
        {
            return Ok(BL.ComunityBL.getYourComunity(code));
        }
        [Route("getRepresentante"), HttpPost]
        public IHttpActionResult getRepresentante([FromBody]int code)
        {
            return Ok(BL.ComunityBL.getRepresentante(code));
        }
        [Route("getSector"), HttpPost]
        public IHttpActionResult getSector([FromBody]int code)
        {
            return Ok(BL.SectorBL.getSector(code));
        }


        //add comunity

        [Route("AddComunity"), HttpPost]
        public IHttpActionResult AddComunity(ComunityDTO com)
        {
            BL.ComunityBL.AddComunity(com);
            return Ok(true);
        }

        [Route("getAllCosto"), HttpGet]
        public IHttpActionResult getAllCosto()

        {

            return Ok(BL.CostoBL.getAllCosto());
        }
        [Route("getAllSectors"), HttpGet]
        public IHttpActionResult getAllSectors()

        {

            return Ok(BL.SectorBL.getAllSectors());
        }
        [Route("getAllRepresentantes"), HttpGet]
        public IHttpActionResult getAllRepresentantes()

        {

            return Ok(BL.RepresentanteBL.getAllRepresentantes());
        }


        [Route("AddRepresentante"), HttpPost]
        public IHttpActionResult AddRepresentante(RepresentanteDTO com)
        {
            BL.RepresentanteBL.AddRepresentante(com);
            return Ok(true);
        }

    }
}
