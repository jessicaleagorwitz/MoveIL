using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ComunityDTO
    {
        public int ComunityCode { get; set; }
        public string ComunityName { get; set; }
        public int CityCode { get; set; }
        public int SectorCode { get; set; }
        public int CostoCode { get; set; }

        public bool anciano { get; set; }
        public string About { get; set; }
        public int RepresentanteCode { get; set; }
    }
}
