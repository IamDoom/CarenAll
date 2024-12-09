using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace CarenAll.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string bedrijfsNaam { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string kvkNummer { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }
   

        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }

    }
}
