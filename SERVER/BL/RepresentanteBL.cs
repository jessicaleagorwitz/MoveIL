using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class RepresentanteBL
    {
     
        //הפונקציה מחזירה את האחראי על קהילה מסוימת
        public static RepresentanteDTO getYourRepresentante(int representanteCode)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                //return CONVERTERES.CityConverters.ConvertCityToDTO(db.NewCities.Single(t => t.CityCode == cityCode));
                return CONVERTERES.RepresentanteConverter.ConvertRepresentanteToDTO(db.Representantes.FirstOrDefault(t => t.RepresentanteCode == representanteCode));

            }
        }

        public static List<RepresentanteDTO> getAllRepresentantes()
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                return CONVERTERES.RepresentanteConverter.ConvertRepresentanteListToDTO(db.Representantes.ToList());
            }
        }

        public static void AddRepresentante(RepresentanteDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Representantes.Add(CONVERTERES.RepresentanteConverter.RepresentantetoDal(com));
                db.SaveChanges();
            }
        }
    }
}
