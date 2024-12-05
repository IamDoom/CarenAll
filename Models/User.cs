namespace CarenAll.Models
{
    public class User
    {
    
        public int Id { get; set; } //primary key

        public string Email { get; set; }
        
    }
    public class Employee : User
    {
        public string EmployeeID { get; set; } // unique
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

    }

    public class PrivateClient : User
    {
        public string PrivateClientID { get; set; } // unique
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class CompanyEmployee : User
    {
        public string CompanyEmployeeID { get; set; }
        public string CompanyID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Company Company { get; set; }
    }

    public class Company: User
    {

        public string CompanyID { get; set; } // Primary key
        public string Adres {  get; set; }
        public string Kvk { get; set; }
        public ICollection<CompanyEmployee> CompanyEmployees { get; set; }
        public int? SubscriptionID { get; set; }
        public Subscription? Subscription { get; set; }
        public ICollection<LeaseRequest> LeaseRequests { get; set; }
    }
}
