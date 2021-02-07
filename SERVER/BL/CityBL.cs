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
                com.NewPoblacion = Convert.ToInt32(com.Poblacion);
                com.NewApt = Convert.ToInt32(com.AlquilerCentro);
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


        public static List<CityDTO> getSearchCity(CityStatusDTO c)
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                if (c.PrecioApt == 1)
                {
                    if (c.Poblacion == 1)
                    {
                   var com = db.NewCities.Where(p => p.NewApt >= 1400 &&
                                   p.DistritoCode == c.Distrito && p.NewPoblacion >= 200000).ToList();
                    if (com == null || com.Count == 0)
                    {
                        var com2 = db.NewCities.Where(p => p.NewApt >= 1400 &&
                         p.NewPoblacion >=  200000).ToList();
                        if (com2 == null || com.Count == 0)
                        {
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1400).ToList());
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                    }
                    return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                   else if (c.Poblacion == 2)
                    {
                        var com = db.NewCities.Where(p => p.NewApt >= 1400 &&
                                  p.DistritoCode == c.Distrito && p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt >= 1400 &&
                            p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1400).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                   else 
                    {
                        var com = db.NewCities.Where(p => p.NewApt >= 1400 &&
                                  p.DistritoCode == c.Distrito && p.NewPoblacion < 100000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt >= 1400 &&
                             p.NewPoblacion < 100000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1400).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                  
                }
                else if (c.PrecioApt == 2)
                {
                    if (c.Poblacion== 1) { 
                   var com = db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400 &&
                                             p.DistritoCode == c.Distrito && p.NewPoblacion >= 200000).ToList();
                    if (com == null || com.Count == 0)
                    {
                        var com2 = db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400 &&
                         p.NewPoblacion >= 200000).ToList();
                        if (com2 == null || com.Count == 0)
                        {
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400).ToList());
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                    }
                    return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                    else if(c.Poblacion== 2)
                    {
                        var com = db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400 &&
                                           p.DistritoCode == c.Distrito && p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400 &&
                            p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                    else
                    {
                        var com = db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400 &&
                                           p.DistritoCode == c.Distrito && p.NewPoblacion <100000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400 &&
                             p.NewPoblacion < 100000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1200 && p.NewApt < 1400).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                   
                }
                else if(c.PrecioApt == 3)
                {
                    if(c.Poblacion== 1)
                    {
                        var com = db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200 &&
                                           p.DistritoCode == c.Distrito && p.NewPoblacion >= 200000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt < 1000 && p.NewApt > 1200 &&
                             p.NewPoblacion >= 200000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                    if (c.Poblacion == 2)
                    {
                   var com = db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200 &&
                                            p.DistritoCode == c.Distrito && p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                    if (com == null || com.Count == 0)
                    {
                        var com2 = db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200 &&
                         p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                        if (com2 == null || com.Count == 0)
                        {
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200 ).ToList());
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                    }
                    return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                    else
                    {
                        var com = db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200 &&
                                           p.DistritoCode == c.Distrito && p.NewPoblacion <100000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200 &&
                             p.NewPoblacion < 100000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt >= 1000 && p.NewApt < 1200).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                   
                }
                else
                {
                    if (c.Poblacion == 1)
                    {
                    var com = db.NewCities.Where(p => p.NewApt < 1000 &&
                                            p.DistritoCode == c.Distrito && p.NewPoblacion >= 200000).ToList();
                    if (com == null || com.Count == 0)
                    {
                        var com2 = db.NewCities.Where(p => p.NewApt < 1000 &&
                         p.NewPoblacion >= 200000).ToList();
                        if (com2 == null || com.Count == 0)
                        {
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt < 1000).ToList());
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                    }
                    return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                    if (c.Poblacion == 2)
                    {
                        var com = db.NewCities.Where(p => p.NewApt < 1000 &&
                                           p.DistritoCode == c.Distrito && p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt < 1000 &&
                             p.NewPoblacion >= 100000 && p.NewPoblacion < 200000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt < 1000).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                    else
                    {
                        var com = db.NewCities.Where(p => p.NewApt < 1000 &&
                                           p.DistritoCode == c.Distrito && p.NewPoblacion < 100000).ToList();
                        if (com == null || com.Count == 0)
                        {
                            var com2 = db.NewCities.Where(p => p.NewApt < 1000 &&
                             p.NewPoblacion < 100000).ToList();
                            if (com2 == null || com.Count == 0)
                            {
                                return CONVERTERES.CityConverters.ConvertCityListToDTO(db.NewCities.Where(p => p.NewApt < 1000).ToList());
                            }
                            return CONVERTERES.CityConverters.ConvertCityListToDTO(com2);
                        }
                        return CONVERTERES.CityConverters.ConvertCityListToDTO(com);
                    }
                   
                }

            }
         }


     }
}
