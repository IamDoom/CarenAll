    // Vehicle entity
    public class Vehicle
    {
        public Guid Id { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string LicensePlate { get; private set; }
        public string Color { get; private set; }
        public DateTime YearOfPurchase { get; private set; }
        public bool IsAvailable { get; private set; }
        public VehicleType Type { get; private set; }

        public Vehicle(string brand, string model, string licensePlate, string color, DateTime yearOfPurchase, VehicleType type)
        {
            Id = Guid.NewGuid();
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
            Color = color;
            YearOfPurchase = yearOfPurchase;
            IsAvailable = true;
            Type = type;
        }

        public void MarkAsUnavailable()
        {
            IsAvailable = false;
        }

        public void MarkAsAvailable()
        {
            IsAvailable = true;
        }
    }