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
                NeighborhoodName = com.NeighborhoodName,
                SinagogueName = com.SinagogueName,
                Size = com.Size,
                SectorCode = com.SectorCode,
                PercentageOfPeople = com.PercentageOfPeople,
                Workers = com.Workers,
                MinAptPrice = com.MinAptPrice,
                MaxAptPrice = com.MaxAptPrice
            };
        }
    }
}
