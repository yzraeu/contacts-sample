using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsSample.API.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
    }
}