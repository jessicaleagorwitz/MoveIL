using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class PlaceOfStudyBL
    {
        public static void AddPlaceOfStudy(PlacesOfStudyDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.PlacesOfStudies.Add(CONVERTERES.PlaceOfStudyConverters.PlaceOfStudytoDal(com));
                db.SaveChanges();
            }
        }
    }
}
