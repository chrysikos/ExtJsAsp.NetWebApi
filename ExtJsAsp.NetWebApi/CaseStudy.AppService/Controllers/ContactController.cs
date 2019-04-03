using CaseStudy.AppService.Models;
using CaseStudy.Domain;
using CaseStudy.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CaseStudy.AppService.Controllers
{
    public class ContactController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                IContactRepository repository = new ContactRepository();
                List<Contact> data = repository.GetAll();

                return Ok(data.ToListDTO());
            }
            catch (Exception ex)
            {
                //log
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody]DTO_Contact contact)
        {
            try
            {
                IContactRepository repository = new ContactRepository();
                repository.Add(contact.ToDomainModel());
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult Put(Guid contactID,[FromBody] DTO_Contact contact)
        {
            return Ok();
        }
    }
}
