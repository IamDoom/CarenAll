using System.ComponentModel.DataAnnotations;
namespace CarenAll.Models
{
    public class Credentials
    {
        [Key]
        public int Id {  get; set; }

        public int RefID { get; set; }

        [Required(ErrorMessage ="Gebruikersnaam is verplicht"),MaxLength(100)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht"),MaxLength(100)]
        public string PasswordHash { get; set; }  // Store hashed password

        public Credentials() { }
        public Credentials(string username, string passwordHash) 
        {
            
            Username = username;
            PasswordHash = passwordHash;
        }

    }
}
