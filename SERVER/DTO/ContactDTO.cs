using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ContactDTO
    {
        public int ContactCode { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Aboutme { get; set; }
        public string Country { get; set; }
        public int CityCode { get; set; }

    }
}
