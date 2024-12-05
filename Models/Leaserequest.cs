namespace CarenAll.Models
{
    public class LeaseRequest
    {
        public int RequestID { get; set; }
        public int RequestorID { get; set; }
        public User Requestor { get; set; }
        public int? CompanyID { get; set; }
        public Company? Company { get; set; }
        public int VehicleID { get; set; }
        public Voertuigen Vehicle { get; set; }
        public int? EmployeeID { get; set; } 
        public Employee? Employee { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string RequestReason { get; set; }
        public int ExpectedDistanceInKM { get; set; }

    }
}
