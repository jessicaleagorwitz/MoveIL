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
               UserCode=com.UserCode,
                FreeDescription=com.FreeDescription

            };
        }

        public static RecommendationDTO ConvertRecommendationToDTO(Recommendation com)
        {
            return new RecommendationDTO
            {
                RecommendationCode = com.RecommendationCode,
                UserCode = com.UserCode,
                FreeDescription = com.FreeDescription
            };
        }



        public static List<RecommendationDTO> ConvertRecommendationListToDTO(List<Recommendation> list)
        {

            return list.Select(p => ConvertRecommendationToDTO(p)).ToList();

        }
    }
}
