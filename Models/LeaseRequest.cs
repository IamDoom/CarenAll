using System.ComponentModel.DataAnnotations;


namespace CarenAll.Models
{
    public class LeaseRequest
    {
        [Key]
        public int RequestID { get; set; }
        [Required]
        public int RequestorID { get; set; }
        public User Requestor { get; set; }
        public int? RequestorCompanyID { get; set; }
        public Company? Company { get; set; }
        [Required]
        public int VehicleID { get; set; }
        public Voertuigen Vehicle { get; set; }
        public int? EmployeeID { get; set; } 
        public Employee? Employee { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string RequestReason { get; set; }
        [Required]
        public int ExpectedDistanceInKM { get; set; }

        public LeaseRequest()
        {

        }
    }
}
