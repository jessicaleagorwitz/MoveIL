using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public class UserConverters
    {
        public static User UsertoDal(UserDTO com)
        {
            return new User
            {
               UserCode=com.UserCode,
               FirstName=com.FirstName,
               LastName=com.LastName,
               Password=com.Password,
              
               Country=com.Country,
               Email=com.Email


            };
        }
        public static UserDTO ConvertUserToDTO(User com)
        {
            return new UserDTO
            {
                UserCode = com.UserCode,
                FirstName = com.FirstName,
                LastName = com.LastName,
                Password = com.Password,

                Country = com.Country,
                Email = com.Email
            };
        }



        public static List<UserDTO> ConvertUserListToDTO(List<User> list)
        {
            return list.Select(p => ConvertUserToDTO(p)).ToList();

        }
    }
}
