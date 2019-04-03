using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Domain
{
    public class Contact
    {
        public Guid ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }

        public static Contact CreateNew(string firstName, string lastName, string phone)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new Exception("FirstName Can't be null or empty.");
            if (string.IsNullOrEmpty(lastName))
                throw new Exception("LastName Can't be null or empty.");
            if (string.IsNullOrEmpty(firstName))
                throw new Exception("Phone Can't be null or empty.");
            if (phone.Length != 10)
                throw new Exception("Phone must be 10 characters");

            return new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone
            };
        }

        private Contact()
        {

        }
    }
}
