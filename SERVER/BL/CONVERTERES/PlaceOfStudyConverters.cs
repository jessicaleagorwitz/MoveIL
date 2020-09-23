using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class PlaceOfStudyConverters
    {
        public static PlacesOfStudy PlaceOfStudytoDal(PlacesOfStudyDTO com)
        {
            return new PlacesOfStudy
            {
                PlaceCode= com.PlaceCode,
                PlaceName=com.PlaceName,
                Address=com.Address,
                SectorCode=com.SectorCode,
                DoesItHaveBoardingSchool=com.DoesItHaveBoardingSchool
            };
        }
    }
}
