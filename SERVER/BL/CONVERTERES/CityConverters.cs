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
        public static NewCity ConvertCitytoDal(CityDTO city)
        {
            return new  NewCity
            {
                CityCode = city.CityCode,
                CityName = city.CityName,
               AboutCity=city.AboutCity ,
               AlquilerAfueras=city.AlquilerAfueras ,
               AlquilerCentro=city.AlquilerCentro,
               DistritoCode=city.DistritoCode,
                Poblacion= city.Poblacion ,
                SalarioMinimo=city.SalarioMinimo ,
                
            };
        }
        public static CityDTO ConvertCityToDTO(NewCity city)
        {
            return new CityDTO
            {
                CityCode=city.CityCode,
                CityName = city.CityName,
                AboutCity = city.AboutCity,
                AlquilerAfueras = city.AlquilerAfueras,
                AlquilerCentro = city.AlquilerCentro,
                DistritoCode = city.DistritoCode,
                Poblacion = city.Poblacion,
                SalarioMinimo = city.SalarioMinimo,
            };
        }

     

        public static List<CityDTO> ConvertCityListToDTO(List<NewCity> list)
        {
           
                return list.Select(p => ConvertCityToDTO(p)).ToList();
            
        }

       
    }
}
