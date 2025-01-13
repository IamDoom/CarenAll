using System.ComponentModel.DataAnnotations;

namespace CarenAll.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } //primary key
        [Required(ErrorMessage = "EmailAdress is required"), EmailAddress, MaxLength(150)]
        public string Email { get; set; }
        
    }
    public class Employee : User
    {
        public int EmployeeID { get; set; } // unique
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

    }

    public class PrivateClient : User
    {
        public int PrivateClientID { get; set; } // unique
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }

    public class CompanyEmployee : User
    {
        public int CompanyEmployeeID { get; set; }
        public int EmployerID { get; set; } //CompanyID
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Company Company { get; set; }
    }

    public class Company: User
    {

        public int CompanyID { get; set; } // Primary key
        public string Adres {  get; set; }
        public string Kvk { get; set; }
        public ICollection<CompanyEmployee> CompanyEmployees { get; set; }
        public int? SubscriptionID { get; set; }
        public Subscription? Subscription { get; set; }
        public ICollection<LeaseRequest> LeaseRequests { get; set; }
    }

    public class PrivateClientDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string firstname {  get; set; }
        public string lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
