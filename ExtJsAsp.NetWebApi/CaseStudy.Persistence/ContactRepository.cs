using CaseStudy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Persistence
{
    public class ContactRepository : IContactRepository
    {
        public List<Contact> GetAll()
        {
            return new List<Contact>()
            {
                Contact.CreateNew("Dimitris","Protopapadakis", "1234567890"),
                Contact.CreateNew("Efstathios","Chrysikos", "1234567890"),
            };
        }
        public void Add(Contact contact)
        {
           
        }
    }
}
