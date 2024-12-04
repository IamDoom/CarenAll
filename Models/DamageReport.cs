using System.Globalization;

namespace CarenAll.Models
{
    public class DamageReport
    {
        public int DamageID { get; set; }
        public string Subject { get; set; } //For keyword or summarizing sentence
        public string Description { get; set; }
        public Employee Writer { get; set; }
    }
}
