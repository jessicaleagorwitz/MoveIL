using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public static class ComunityConverters
    {
        public static Comunity ConvertComunitytoDal(ComunityDTO com)
        {
            return new Comunity
            {
                ComunityCode = com.ComunityCode,
                ComunityName = com.ComunityName,
                CityCode = com.CityCode,
                
                SectorCode = com.SectorCode,
                CostoCode= com.CostoCode,
                anciano=com.anciano,
                About=com.About ,
                RepresentanteCode=com.RepresentanteCode
               
            };
        }
        public static ComunityDTO ConvertComunityToDTO(Comunity com)
        {
            return new ComunityDTO
            {
                ComunityCode = com.ComunityCode,
                ComunityName = com.ComunityName,
                CityCode = com.CityCode,

                SectorCode = com.SectorCode,
                CostoCode = com.CostoCode,
                anciano = com.anciano,
                About = com.About,
                RepresentanteCode = com.RepresentanteCode
            };
        }



        public static List<ComunityDTO> ConvertComunityListToDTO(List<Comunity> list)
        {

            return list.Select(p => ConvertComunityToDTO(p)).ToList();

        }
        

    }
}
