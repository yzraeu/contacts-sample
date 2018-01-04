using ContactsSample.API.Infrastructure.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ContactsSample.API.Models
{
    public class ContactPhoneNumber : BaseEntity, IValidate
    {
        public virtual Contact ContactId { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(PhoneNumber);
        }
    }
}