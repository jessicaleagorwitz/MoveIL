using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public static class ContactsConverters
    {
        public static NewContact ConvertContactsToDAL(DTO.ContactDTO Contacts)
        {
            return new NewContact
            {
                
              
                ContactName= Contacts.ContactName,
                PhoneNumber= Contacts.PhoneNumber,
                Email= Contacts.Email,
                Aboutme= Contacts.Aboutme,
                Country= Contacts.Country,
                CityCode=Contacts.CityCode
                
             
            };
        }
        public static DTO.ContactDTO ConvertContactToDTO(NewContact Contacts)
        {
            return new DTO.ContactDTO
            {

             
                ContactName = Contacts.ContactName,
                PhoneNumber = Contacts.PhoneNumber,
                Email = Contacts.Email,
                Aboutme = Contacts.Aboutme,
                Country = Contacts.Country,
                CityCode = Contacts.CityCode
            };
        }

        public static List<DTO.ContactDTO> ConvertContactsListToDTO(List<NewContact> contact)
        {
            return contact.Select(p => ConvertContactToDTO(p)).ToList();
        }
    }
}
