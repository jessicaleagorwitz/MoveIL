using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class UserBL
    {
        public static void AddUser(UserDTO com)
        {
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                db.Users.Add(CONVERTERES.UserConverters.UsertoDal(com));
                db.SaveChanges();
            }
        }
    }
}
