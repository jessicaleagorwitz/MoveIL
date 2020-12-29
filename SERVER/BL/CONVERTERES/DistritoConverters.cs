using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
    public class DistritoConverters
    {
        public static NewDistrito ConvertDistritotoDal(DistritoDTO com)
        {
            return new NewDistrito
            {
                DistritoCode = com.DistritoCode,
                DistritoName =com.DistritoName
            };
        }
        public static DistritoDTO ConvertDistritoToDTO(NewDistrito com)
        {
            return new DistritoDTO
            {
              DistritoCode=com.DistritoCode,
                DistritoName = com.DistritoName
            };
        }
        public static List<DistritoDTO> ConvertDistritoListToDTO(List<NewDistrito> contact)
        {
            return contact.Select(p => ConvertDistritoToDTO(p)).ToList();
        }


    }
}
