using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class CountryBL
    {
        public static void AddCountry(CountryDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Countries.Add(CONVERTERES.CountryConverters.ConvertCountrytoDal(com));
                db.SaveChanges();
            }
        }
        public static List<CountryDTO> getShowCountry()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.CountryConverters.ConvertCountryListToDTO(db.Countries.ToList());
            }
        }
       
    }
}
