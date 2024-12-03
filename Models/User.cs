namespace CarenAll.Models
{
    public class User
    {
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
    }
    public class Employee : User
    {
        public string Type { get; set; }

    }

    public class PrivateClient : User
    {
        public string PhoneNumber { get; set; }
    }

    public class BusinessClient : User
    {
        public BusinessManager Manager { get; set; }
    }

    public class BusinessManager : BusinessClient
    {
        public string ManagerSpecificProperty { get; set; }
        public ICollection<BusinessClient> Clients { get; set; }
    }
}
