using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CityBL
    {
        public static void AddCity(CityDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.NewCities.Add(CONVERTERES.CityConverters.ConvertCitytoDal(com));
                db.SaveChanges();
            }
        }

        //מציגה את כל הערים
        public static List<CityDTO> getShowCity()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.ToList());
            }
        }

      
        // מציגה עיר אחת לפי הקוד שלה
        public static CityDTO getYourCity(int cityCode)
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                //return CONVERTERES.CityConverters.ConvertCityToDTO(db.NewCities.Single(t => t.CityCode == cityCode));
                return CONVERTERES.CityConverters.ConvertCityToDTO(db.NewCities.FirstOrDefault(t => t.CityCode == cityCode));

            }
        }

       

      
    }
}
