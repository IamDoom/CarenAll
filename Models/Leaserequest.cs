namespace CarenAll.Models
{
    public class Leaserequest
    {
        public int RequestID { get; set; }
        public int VehicleID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string requestor { get; set; }
        public string company {  get; set; }
        
    }
}
