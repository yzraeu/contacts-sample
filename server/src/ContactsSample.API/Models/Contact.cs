using ContactsSample.API.Infrastructure.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContactsSample.API.Models
{
    public class Contact : BaseEntity, IValidate
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.FirstName)) return false;

            if (string.IsNullOrEmpty(this.LastName)) return false;

            if (this.DateOfBirth > DateTime.Now) return false;

            return true;
        }
    }
}