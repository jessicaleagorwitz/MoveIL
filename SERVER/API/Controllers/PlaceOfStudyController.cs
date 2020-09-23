using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PlaceOfStudyController : ApiController
    {
        public void AddPlaceOfStudy(PlacesOfStudyDTO com)
        {
            BL.PlaceOfStudyBL.AddPlaceOfStudy(com);
        }
    }
}
