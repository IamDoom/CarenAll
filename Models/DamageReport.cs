using System.Globalization;

namespace CarenAll.Models
{
    public class DamageReport
    {
        public int DamageID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DriverID {  get; set; }
        public User Driver {  get; set; }

        public int VehicleID { get; set; }
        public Voertuigen Vehicle { get; set; }
        public string Subject { get; set; } //For keyword or summarizing sentence
        public string Description { get; set; }
        public string ReporterID { get; set; }
        public Employee Reporter { get; set; }
    }
}
