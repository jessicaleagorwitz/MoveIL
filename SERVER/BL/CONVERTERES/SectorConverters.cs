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
            
               SectorName=com.SectorName

            };
        }
    }
}
