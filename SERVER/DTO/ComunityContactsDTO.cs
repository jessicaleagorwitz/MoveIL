using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ComunityContactsDTO
    {
        public int ContactCode { get; set; }
        public int ComunityCode { get; set; }
        public int ProfessionCode { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string FamilyStatus { get; set; }
        public int SectorCode { get; set; }
        public string YearOfAlia { get; set; }
        public bool DoesSpeakSpanish { get; set; }
    }
}
