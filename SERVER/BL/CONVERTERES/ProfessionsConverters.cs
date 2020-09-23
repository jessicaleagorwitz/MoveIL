using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
  public  class ProfessionsConverters
    {
        public static Profession ProfessionstoDal(ProfessionsDTO com)
        {
            return new Profession
            {
                ProfessionCode=com.ProfessionCode,
                ProfessionName=com.ProfessionName
            };
        }
    }
}
