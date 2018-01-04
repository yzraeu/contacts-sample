using ContactsSample.API.Models;
using ContactsSample.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactsSample.API.Controllers
{
    public class ContactsController : ApiController
    {
        private readonly IRepository<Contact> contactRepository;

        public ContactsController(IRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        // GET api/values
        public IEnumerable<Contact> Get()
        {
            return this.contactRepository.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
