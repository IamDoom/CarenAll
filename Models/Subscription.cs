using System.ComponentModel.DataAnnotations;


namespace CarenAll.Models
{
    public class Subscription
    {
        [Key]
        public int SubcriptionID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; } //duration is in days
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool Upfront { get; set; } //pay as you go option
        public List<SubscriptionUpdate> UpdateHistory { get; set; } = new List<SubscriptionUpdate>();

    }

    public class SubscriptionUpdate //model for logging changes made by which employee
    {
        [Key]
        public int UpdateID { get; set; }
        [Required]
        public DateTime UpdateTime { get; set; }
        [Required]
        public int UpdatedByEmployeeID { get; set; } 

    }
}