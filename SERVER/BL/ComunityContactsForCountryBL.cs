using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class ComunityContactsForCountryBL
    {
        public static void AddComunityContactsForCountry(ComunityContactsForCountryDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.ComunityContactsForCountries.Add(CONVERTERES.ComunityContactsForCountryConverters.ConvertComunityContactsForCountrytoDal(com));
                db.SaveChanges();
            }
        }
    }
}
