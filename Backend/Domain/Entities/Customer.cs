    // Customer entity
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsCorporate { get; private set; }
        public string? CompanyName { get; private set; }
        public Subscription? Subscription { get; private set; }

        public Customer(string name, string email, string password, bool isCorporate)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
            IsCorporate = isCorporate;
        }

        public void AssignSubscription(Subscription subscription)
        {
            Subscription = subscription;
        }

        public void SetCompanyName(string companyName)
        {
            CompanyName = companyName;
        }
    }
