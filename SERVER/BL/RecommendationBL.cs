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
        public static void AddRecommendation(RecommendationDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Recommendations.Add(CONVERTERES.RecommendationConverters.RecommendationtoDal(com));
                db.SaveChanges();
            }
        }
    }
}
