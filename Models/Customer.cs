using System.ComponentModel.DataAnnotations;

namespace CarenAll.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; }

        [Required, Phone, MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; }
    }
}