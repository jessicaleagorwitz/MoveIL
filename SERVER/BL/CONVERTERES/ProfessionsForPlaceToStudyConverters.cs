using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class ProfessionsForPlaceToStudyConverters
    {
        public static ProfessionsForPlaceToStudy ProfessionsForPlaceToStudytoDal(ProfessionsForPlaceToStudyDTO com)
        {
            return new ProfessionsForPlaceToStudy
            {
               PlaceCode=com.PlaceCode,
               ProfessionCode=com.ProfessionCode,
               AmountYears=com.AmountYears,
               DoesSpeakHebrew=com.DoesSpeakHebrew

            };
        }
    }
}
