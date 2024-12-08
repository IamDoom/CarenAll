namespace CarenAll.Models
{
    public class Credentials
    {
        public int Id {  get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }  // Store hashed password

    }
}
