using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PlacesOfStudyDTO
    {
        public int PlaceCode { get; set; }
        public string PlaceName { get; set; }
        public string Address { get; set; }
        public int SectorCode { get; set; }
        public bool DoesItHaveBoardingSchool { get; set; }
    }
}
