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
               UserName=com.UserName,
               FirstName=com.FirstName,
               LastName=com.LastName,
               Password=com.Password,
               PhoneNumber=com.PhoneNumber,
               CountryCode=com.CountryCode,
               Email=com.Email


            };
        }
    }
}
