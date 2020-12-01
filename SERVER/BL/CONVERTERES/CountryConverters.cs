using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
    public class CountryConverters
    {
        public static Country ConvertCountrytoDal(CountryDTO com)
        {
            return new Country
            {
                CountryName = com.CountryName
            };
        }
        public static CountryDTO ConvertCountryToDTO(Country com)
        {
            return new CountryDTO
            {
                
                CountryName = com.CountryName
            };
        }
        public static List<CountryDTO> ConvertCountryListToDTO(List<Country> contact)
        {
            return contact.Select(p => ConvertCountryToDTO(p)).ToList();
        }


    }
}
