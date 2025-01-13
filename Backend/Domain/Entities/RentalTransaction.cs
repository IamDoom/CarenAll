    // Rental Transaction entity
    public class RentalTransaction
    {
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public Guid VehicleId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public RentalTransaction(Guid customerId, Guid vehicleId, DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid();
            CustomerId = customerId;
            VehicleId = vehicleId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }