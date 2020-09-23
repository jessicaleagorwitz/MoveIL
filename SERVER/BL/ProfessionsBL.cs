using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class ProfessionsBL
    {
        public static void AddProfessions(ProfessionsDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Professions.Add(CONVERTERES.ProfessionsConverters.ProfessionstoDal(com));
                db.SaveChanges();
            }
        }
    }
}
