using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public  class ContactBL
    {

        public static void AddContacts(DTO.ContactDTO Contacts)
        {
            using(MoveilEntities db = new MoveilEntities() )
            {
                db.NewContacts.Add(CONVERTERES.ContactsConverters.ConvertContactsToDAL(Contacts));
                db.SaveChanges();
            }
        }
        public static List<DTO.ContactDTO> getShowContacts()
        {
            using (MoveilEntities db = new MoveilEntities())
            {
                return CONVERTERES.ContactsConverters.ConvertContactsListToDTO(db.NewContacts.ToList());
            }
        }


        // מציגה את האנשי קשר לעיר המוימת לפי קוד העיר
        public static List<ContactDTO> getContact(int cityCode)
        {
            using (MoveilEntities db = new MoveilEntities())
            {

                return CONVERTERES.ContactsConverters.ConvertContactsListToDTO(db.NewContacts.Where(t => t.CityCode == cityCode).ToList());

            }
        }
    }
}
