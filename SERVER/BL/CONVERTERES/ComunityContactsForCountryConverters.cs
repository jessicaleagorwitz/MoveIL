using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
  public  class ComunityContactsForCountryConverters
    {
        public static ComunityContactsForCountry ConvertComunityContactsForCountrytoDal(ComunityContactsForCountryDTO com)
        {
            return new ComunityContactsForCountry
            {
               ComunityCode=com.ComunityCode,
               CountryCode=com.CountryCode,
               NumbreOfResidents=com.NumbreOfResidents
            };
        }
    }
}
