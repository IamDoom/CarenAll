    // Subscription entity
    public class Subscription
    {
        public Guid Id { get; private set; }
        public string Type { get; private set; }
        public decimal Cost { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }

        public Subscription(string type, decimal cost, DateTime startDate)
        {
            Id = Guid.NewGuid();
            Type = type;
            Cost = cost;
            StartDate = startDate;
        }

        public void EndSubscription(DateTime endDate)
        {
            EndDate = endDate;
        }
    }