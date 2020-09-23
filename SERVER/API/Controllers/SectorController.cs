using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class SectorController : ApiController
    {
        public void AddSector(SectorDTO com)
        {
            BL.SectorBL.AddSector(com);
        }
    }
}
