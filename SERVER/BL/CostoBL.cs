using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class CostoBL
    {
        public static void AddCosto(CostoDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.NewCostoes.Add(CONVERTERES.CostoConverters.ConvertCostotoDal(com));
                db.SaveChanges();
            }
        }
       
        
        public static List<CostoDTO> getAllCosto()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.CostoConverters.ConvertCostoListToDTO(db.NewCostoes.ToList());
            }
        }
       
    }
}
