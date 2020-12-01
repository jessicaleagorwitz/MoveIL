using DAL;
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

        public static List<CityDTO> getShowCity()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.Cities.ToList());
            }
        }
    }
}
