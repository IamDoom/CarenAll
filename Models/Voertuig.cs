using System.ComponentModel.DataAnnotations;

namespace CarenAll.Models;

public class Voertuigen
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Merk { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string Kenteken { get; set; }

    [Required]
    public string Kleur { get; set; }

    [Required]
    public int Aanschafjaar { get; set; }

    public User InUseBy { get; set; }
    public string State { get; set; }
}

public class Auto : Voertuigen
{

}

public class Camper : Voertuigen
{

}

public class Caravan : Voertuigen
{

}