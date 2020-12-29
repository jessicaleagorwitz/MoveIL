using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class DistritoBL
    {
        public static void AddDistrito(DistritoDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.NewDistritoes.Add(CONVERTERES.DistritoConverters.ConvertDistritotoDal(com));
                db.SaveChanges();
            }
        }

      //מציג את המחוזות
        public static List<DistritoDTO> getDistrito()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.DistritoConverters.ConvertDistritoListToDTO(db.NewDistritoes.ToList());
            }
        }


        //מציג את הערים המתאימות לכל אחד מהמחוזות  
        public static List<CityDTO> getDistritoCode(int Code)
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(t => t.DistritoCode == Code).ToList());

            }
        }
    }
}
