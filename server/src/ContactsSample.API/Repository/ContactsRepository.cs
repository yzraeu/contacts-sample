using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ContactsSample.API.Models;
using Dapper;

namespace ContactsSample.API.Repository
{
    public class ContactsRepository : BaseRepository, IRepository<Contact>
    {
        public IEnumerable<Contact> GetAll()
        {
            var contacts = base.ConnectionFactory().Query<Contact>("select id, firstname, lastname, dateofbirth, addeddate from contacts");

            return contacts;
        }

        public Contact Get(int id)
        {
            var contact = base.ConnectionFactory().QueryFirst<Contact>("select id, firstname, lastname, dateofbirth, addeddate from contacts where id = @id", new { id });

            return contact;
        }

        public void Add(Contact entity)
        {
            base.ConnectionFactory().Execute("insert into contacts values(@firstName, @lastName, @dateOfBirth)",
                new
                {
                    firstName = entity.FirstName,
                    lastName = entity.LastName,
                    dateOfBirth = entity.DateOfBirth,
                });
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}