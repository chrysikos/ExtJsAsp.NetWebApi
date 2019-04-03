using CaseStudy.AppService.Models;
using CaseStudy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy.AppService
{
    public static class Mapper
    {
        public static List<DTO_Contact> ToListDTO(this List<Contact> source)
        {
            List<DTO_Contact> result = new List<DTO_Contact>();
            foreach (Contact contact in source)
            {
                result.Add(contact.ToDTO());
            }

            return result;
        }

        public static DTO_Contact ToDTO(this Contact contact)
        {
            return new DTO_Contact
            {
                ID = contact.ID,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone
            };
        }

        public static Contact ToDomainModel(this DTO_Contact contact)
        {
            return Contact.CreateNew(contact.FirstName, contact.LastName, contact.Phone);
           
        }
    }
}