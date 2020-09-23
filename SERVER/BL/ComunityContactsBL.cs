using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class ComunityContactsBL
    {

        public static void AddComunityContacts(ComunityContactsDTO comunityContacts)
        {
            using(MoveilEntities db = new MoveilEntities() )
            {
                db.ComunityContacts.Add(CONVERTERES.ComunityContactsConverters.ConvertComunityContactsToDAL(comunityContacts));
                db.SaveChanges();
            }
        }
        public static List<ComunityContactsDTO> getShowComunityContacts()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.ComunityContactsConverters.ConvertComunityContactsListToDTO(db.ComunityContacts.ToList());
            }
        }
    }
}
