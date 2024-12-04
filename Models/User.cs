namespace CarenAll.Models
{
    public class User
    {
    
        public int Id { get; set; } //primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
    }
    public class Employee : User
    {
        public string EmployeeID { get; set; } // unique
        public string Role { get; set; }

    }

    public class PrivateClient : User
    {
        public string PrivateID { get; set; } // unique
        public string PhoneNumber { get; set; }
    }

    public class CompanyEmployee : User
    {
        public string CompanyID { get; set; }
        public Company company { get; set; }
    }

    public class Company
    {

        public string CompanyID { get; set; } // Primary key
        public string Adres {  get; set; }
        public string Kvk { get; set; }
        public ICollection<CompanyEmployee> CompanyEmployees { get; set; }
        public Subscription subscription { get; set; } //nullable in case subscription has not been selected or has expired
    }
}
