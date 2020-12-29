using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class RepresentanteConverter
    {
        public static Representante RepresentantetoDal(RepresentanteDTO com)
        {
            return new Representante
            {
               
                 Name=com.Name,
                 Email=com.Email ,
                  PhoneNumber=com.PhoneNumber

            };
        }
        public static RepresentanteDTO ConvertRepresentanteToDTO(Representante rep)
        {
            return new RepresentanteDTO
            {
                RepresentanteCode=rep.RepresentanteCode,
                Name = rep.Name,
                Email = rep.Email,
                PhoneNumber = rep.PhoneNumber

            };
        }

    }
}
