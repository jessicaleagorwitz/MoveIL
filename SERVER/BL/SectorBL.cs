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
        public static void AddSector(SectorDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Sectors.Add(CONVERTERES.SectorConverters.SectortoDal(com));
                db.SaveChanges();
            }
        }
       
    }
}
