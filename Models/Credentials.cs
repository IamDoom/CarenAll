namespace CarenAll.Models
{
    public class Credentials
    {
        public int id {  get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }  // Store hashed password
        public int UserId { get; set; }  // Foreign Key from User table
        public User User { get; set; }  // Navigation property
    }
}
