using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL
    {
       
        //יצירת משתמש חדש
        public static bool AddUser(UserDTO com)
        {
            //
            using (DAL.MoveilEntities db = new DAL.MoveilEntities())
            {
                //var c = CONVERTERES.UserConverters.ConvertUserToDTO(db.Users.FirstOrDefault(t => t.Email.Equals(com.Email)));
                //if (c == null)
                //{
                    
                    db.Users.Add(CONVERTERES.UserConverters.UsertoDal(com));
                    db.SaveChanges();
                    return true;
              //  }
               // else return false;
            }
        }

        public static UserDTO getUserCode(int code)
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.UserConverters.ConvertUserToDTO(db.Users.FirstOrDefault(t => t.UserCode == code));
            }
        }


        // הפונקציה בודקת אם המייל קיים כבר במערכת , אם כן מחזירה 
        //תשובה שלילית ואם לא  חיובת יכול להשתמש במייל הזה
        public static bool SingInCheckUser(string email)
        {
            using (MoveilEntities db = new MoveilEntities())
            {

                var u = CONVERTERES.UserConverters.ConvertUserToDTO(db.Users.FirstOrDefault(t => t.Email.Equals(email)));
                if (u != null)
                {
                    return false;
                }
                return true;
            }
        }


        //הפונקציה בודקת האם המשתמש קיים אם כן מחזיר תשובה חיובית אם לא שלילית
        public static UserDTO LogIn(LoginDTO log)
        {
            using (MoveilEntities db = new MoveilEntities())
            {

                var u = CONVERTERES.UserConverters.ConvertUserToDTO(db.Users.FirstOrDefault(t => t.Email.Equals(log.Email) && t.Password == log.Password));
                if (u != null)
                {
                    return u;
                }
                return null;
            }
        }
    }
}
