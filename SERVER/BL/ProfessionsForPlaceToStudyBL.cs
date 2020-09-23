using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class ProfessionsForPlaceToStudyBL
    {
        public static void AddProfessionsForPlaceToStudy(ProfessionsForPlaceToStudyDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.ProfessionsForPlaceToStudies.Add(CONVERTERES.ProfessionsForPlaceToStudyConverters.ProfessionsForPlaceToStudytoDal(com));
                db.SaveChanges();
            }
        }
    }
}
