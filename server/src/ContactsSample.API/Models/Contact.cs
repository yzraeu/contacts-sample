using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsSample.API.Models
{
    public class Contact : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}