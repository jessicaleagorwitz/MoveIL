using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class CityBL
    {
        public static void AddCity(CityDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Cities.Add(CONVERTERES.CityConverters.ConvertCitytoDal(com));
                db.SaveChanges();
            }
        }
    }
}
