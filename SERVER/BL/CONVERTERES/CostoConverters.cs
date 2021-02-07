using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class CostoConverters
    {
        public static NewCosto ConvertCostotoDal(CostoDTO com)
        {
            return new NewCosto
            {
                CostoCode=com.CostoCode,
                CostoName=com.CostoName
            };
        }
        public static DTO.CostoDTO ConvertCostoToDTO(NewCosto com)
        {
            return new DTO.CostoDTO
            {
                CostoCode = com.CostoCode,
                CostoName = com.CostoName


            };
        }

        public static List<DTO.CostoDTO> ConvertCostoListToDTO(List<NewCosto> co)
        {
            return co.Select(p => ConvertCostoToDTO(p)).ToList();
        }
    }
}
