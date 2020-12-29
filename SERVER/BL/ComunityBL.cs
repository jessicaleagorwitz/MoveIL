using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ComunityBL
    {
        public static void AddComunity(ComunityDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Comunities.Add(CONVERTERES.ComunityConverters.ConvertComunitytoDal(com));
                db.SaveChanges();
            }
        }


        //הפונקציה מציגה קהילה מסוימת לפי הקוד שלה
        public static ComunityDTO getYourComunity(int comunityCode)
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                //return CONVERTERES.CityConverters.ConvertCityToDTO(db.NewCities.Single(t => t.CityCode == cityCode));
                return CONVERTERES.ComunityConverters.ConvertComunityToDTO(db.Comunities.FirstOrDefault(t => t.ComunityCode == comunityCode));

            }
        }
      
        // הפונקציה מחפשת קהולית מתאימות לפי מחזר, סטטוס משפחתי ויכולת כספי
        public static List<ComunityDTO> getComunity(PersonalStatusDTO per)
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                if (per.QuienSoy == 2)
                {
                    
                   var com= CONVERTERES.ComunityConverters.ConvertComunityListToDTO
                        (db.Comunities.Where(p => p.CostoCode == per.StatusEconomico && 
                        p.SectorCode == per.Religion && p.anciano== true).ToList());

                    if (com == null)
                    {
                        var com2= CONVERTERES.ComunityConverters.ConvertComunityListToDTO
                        (db.Comunities.Where(p => p.CostoCode == per.StatusEconomico &&
                         p.anciano == true).ToList());

                        if (com2 == null)
                        {
                            return CONVERTERES.ComunityConverters.ConvertComunityListToDTO
                        (db.Comunities.Where(p => p.CostoCode == per.StatusEconomico).ToList());
                        }
                        else return com2;
                    }
                    else return com;
                }
                else
                {
                    var com= CONVERTERES.ComunityConverters.ConvertComunityListToDTO(
                        db.Comunities.Where(p => p.CostoCode == per.StatusEconomico && 
                        p.SectorCode == per.Religion).ToList());
                    if (com == null)
                    {
                        return  CONVERTERES.ComunityConverters.ConvertComunityListToDTO(
                        db.Comunities.Where(p => p.SectorCode == per.Religion).ToList());
                       
                    }
                    else return com;

                }
            }

        }
   
        public static RepresentanteDTO getRepresentante(int code)
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                //return CONVERTERES.CityConverters.ConvertCityToDTO(db.NewCities.Single(t => t.CityCode == cityCode));
                return CONVERTERES.RepresentanteConverter.ConvertRepresentanteToDTO(db.Representantes.FirstOrDefault(t => t.RepresentanteCode == code));

            }
        }
    }
}

