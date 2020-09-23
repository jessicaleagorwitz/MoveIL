using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
 public   class CountryConverters
    {
        public static Country ConvertCountrytoDal(CountryDTO com)
        {
            return new Country
            {
               CountryCode=com.CountryCode,
               CountryName=com.CountryName
            };
        }
    }
}
