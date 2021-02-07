using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CityDTO
    {
        //no veo nada jajaajj
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public int DistritoCode { get; set; }
        public string Poblacion { get; set; }
        public string AlquilerCentro { get; set; }
        public string AlquilerAfueras { get; set; }
        public string SalarioMinimo { get; set; }
        public string AboutCity { get; set; }

        public int NewPoblacion { get; set; }
        public int NewApt { get; set; }
    }
}
