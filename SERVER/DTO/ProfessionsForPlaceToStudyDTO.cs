using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class ProfessionsForPlaceToStudyDTO
    {
        public int PlaceCode { get; set; }
        public int ProfessionCode { get; set; }
        public string AmountYears { get; set; }
        public bool DoesSpeakHebrew { get; set; }
    }
}
