using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public class RecommendationBL
    {
        //יצירת המלצה חדשה
        public static bool AddRecommendation(RecommendationDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
               
                db.Recommendations.Add(CONVERTERES.RecommendationConverters.RecommendationtoDal(com));
                
                db.SaveChanges();
                return true;
            }
        }

        //מציגה את המלצות
        public static List<RecommendationDTO> getShowRecommendation()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
               
                return CONVERTERES.RecommendationConverters.ConvertRecommendationListToDTO(db.Recommendations.ToList().OrderBy(x => Guid.NewGuid()).Take(3).ToList());
            }
        }
    }
}
