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
            var contacts = base.ConnectionFactory().Query<Contact>("select id, firstname, lastname, dateofbirth, addeddate from contacts order by firstname, id");

            return contacts;
        }

        public Contact Get(int id)
        {
            var contact = base.ConnectionFactory().QueryFirstOrDefault<Contact>("select id, firstname, lastname, dateofbirth, addeddate from contacts where id = @id", new { id });

            return contact;
        }

        public int Add(Contact entity)
        {
            var id = base.ConnectionFactory().Query<int>($"insert into contacts(firstName, lastName, dateOfBirth) values(@firstName, @lastName, @dateOfBirth); {selectLastIdSQL}",
                new
                {
                    firstName = entity.FirstName,
                    lastName = entity.LastName,
                    dateOfBirth = entity.DateOfBirth,
                }).Single();

            return id;
        }

        public void Update(int id, Contact entity)
        {
            base.ConnectionFactory().Execute("update contacts set firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth where id = @id",
                new
                {
                    firstName = entity.FirstName,
                    lastName = entity.LastName,
                    dateOfBirth = entity.DateOfBirth,
                    id
                });
        }

        public void Remove(int id)
        {
            base.ConnectionFactory().Execute("delete from contacts where id = @id", new { id });
        }

        public bool Exists(int id)
        {
            var exists = base.ConnectionFactory().QueryFirstOrDefault("select 0 from contacts where id = @id", new { id }) != null;

            return exists;
        }
    }
}