using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class CityConverters
    {
        public static City ConvertCitytoDal(CityDTO city)
        {
            return new  City
            {
               CityCode= city.CityCode,
               CityName= city.CityName
            };
        }
    }
}
