using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SectorBL
    {

        public static SectorDTO getSector(int Code)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                //return CONVERTERES.CityConverters.ConvertCityToDTO(db.NewCities.Single(t => t.CityCode == cityCode));
                return CONVERTERES.SectorConverters.ConvertSectorToDTO(db.Sectors.FirstOrDefault(t => t.SectorCode == Code));

            }
        }

        public static List<SectorDTO> getAllSectors()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.SectorConverters.ConvertSectorListToDTO(db.Sectors.ToList());
            }
        }
    }
}
