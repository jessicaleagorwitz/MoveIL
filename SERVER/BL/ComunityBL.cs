using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ComunityBL
    {
        public static void AddComunity(ComunityDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Comunities.Add(CONVERTERES.ComunityConverters.ConvertComunitytoDal(com));
                db.SaveChanges();
            }
        }
      
    }
}
