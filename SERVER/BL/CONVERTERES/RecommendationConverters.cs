using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class RecommendationConverters
    {
        public static Recommendation RecommendationtoDal(RecommendationDTO com)
        {
            return new Recommendation
            {
                RecommendationCode=com.RecommendationCode,
                ContactCode=com.ContactCode,
                FreeDescription=com.FreeDescription

            };
        }
    }
}
