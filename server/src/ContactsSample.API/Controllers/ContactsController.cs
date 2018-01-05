using ContactsSample.API.Infrastructure.Extensions;
using ContactsSample.API.Models;
using ContactsSample.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ContactsSample.API.Controllers
{
    public class ContactsController : ApiController
    {
        private readonly IRepository<Contact> contactRepository;

        public ContactsController(IRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public IHttpActionResult Get()
        {
            return Ok(this.contactRepository.GetAll());
        }

        public IHttpActionResult Get(int id)
        {
            var contact = this.contactRepository.Get(id);

            if (contact == null)
                return NotFound();
            else
                return Ok();
        }

        public IHttpActionResult Post([FromBody]Contact contact)
        {
            if (!ModelState.IsValid || !contact.IsValid()) return BadRequest();

            try
            {
                var id = this.contactRepository.Add(contact);
                contact = this.contactRepository.Get(id);
                return Created(nameof(Get), contact);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        public IHttpActionResult Put(int id, [FromBody]Contact contact)
        {
            if (!this.contactRepository.Exists(id)) return NotFound();

            if (!ModelState.IsValid || !contact.IsValid()) return BadRequest();

            try
            {
                this.contactRepository.Update(id, contact);
                return this.Accepted();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Delete(int id)
        {
            if (!this.contactRepository.Exists(id)) return NotFound();

            try
            {
                this.contactRepository.Remove(id);
                return this.Accepted();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
