using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERES
{
   public static class ComunityContactsConverters
    {
        public static ComunityContact ConvertComunityContactsToDAL(ComunityContactsDTO comunityContacts)
        {
            return new ComunityContact
            {
                
                ComunityCode = comunityContacts.ComunityCode,
                ProfessionCode = comunityContacts.ProfessionCode,
                ContactName = comunityContacts.ContactName,
                PhoneNumber = comunityContacts.PhoneNumber,
                Address = comunityContacts.Address,
                BirthDate = comunityContacts.BirthDate,
                FamilyStatus = comunityContacts.FamilyStatus,
                SectorCode = comunityContacts.SectorCode,
                YearOfAlia = comunityContacts.YearOfAlia,
                DoesSpeakSpanish = comunityContacts.DoesSpeakSpanish
            };
        }
        public static ComunityContactsDTO ConvertComunityContactToDTO(ComunityContact comunityContacts)
        {
            return new ComunityContactsDTO
            {
                
                ComunityCode = comunityContacts.ComunityCode,
                ProfessionCode = comunityContacts.ProfessionCode,
                ContactName = comunityContacts.ContactName,
                PhoneNumber = comunityContacts.PhoneNumber,
                Address = comunityContacts.Address,
                BirthDate = comunityContacts.BirthDate,
                FamilyStatus = comunityContacts.FamilyStatus,
                SectorCode = comunityContacts.SectorCode,
                YearOfAlia = comunityContacts.YearOfAlia,
                DoesSpeakSpanish = comunityContacts.DoesSpeakSpanish
            };
        }

        public static List<ComunityContactsDTO> ConvertComunityContactsListToDTO(List<ComunityContact> contact)
        {
            return contact.Select(p => ConvertComunityContactToDTO(p)).ToList();
        }
    }
}
