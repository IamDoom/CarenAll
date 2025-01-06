using System.Globalization;
using System.ComponentModel.DataAnnotations;


namespace CarenAll.Models
{
    public class DamageReport
    {
        [Key]
        public int ReportID { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public int DriverID {  get; set; }

        public User Driver {  get; set; }
        [Required]
        public int VehicleID { get; set; }
        public Voertuigen Vehicle { get; set; }
        [Required]
        public string Subject { get; set; } //For keyword or summarizing sentence
        [Required]
        public string Description { get; set; }
        [Required]
        public int ReporterID { get; set; }
        public Employee Reporter { get; set; }
    }
}
