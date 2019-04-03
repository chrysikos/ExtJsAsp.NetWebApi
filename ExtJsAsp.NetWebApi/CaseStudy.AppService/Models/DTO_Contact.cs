using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseStudy.AppService.Models
{
    public class DTO_Contact
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}