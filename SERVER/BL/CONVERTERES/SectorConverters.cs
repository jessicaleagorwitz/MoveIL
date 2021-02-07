using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class SectorConverters
    {
        public static Sector SectortoDal(SectorDTO com)
        {
            return new Sector
            {
            SectorCode=com.SectorCode,
               SectorName=com.SectorName

            };


        }

        public static SectorDTO ConvertSectorToDTO(Sector com)
        {
            return new SectorDTO
            {
                SectorCode = com.SectorCode,
                SectorName = com.SectorName
            };
        }

        public static List<SectorDTO> ConvertSectorListToDTO(List<Sector> list)
        {

            return list.Select(p => ConvertSectorToDTO(p)).ToList();

        }
    }
}
