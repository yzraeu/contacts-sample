using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsSample.API.Models
{
    public class ContactPhoneNumber : BaseEntity
    {
        public virtual Contact ContactId { get; set; }
        public string PhoneNumber { get; set; }
    }
}