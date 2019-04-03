using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Domain
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        void Add(Contact contact);
    }
}
