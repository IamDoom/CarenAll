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

    //ik raadt dit later aan
    /* public Voertuigen(string merk, string type, string kenteken, string kleur, int aanschafjaar)
    {
        Merk = merk;
        Type = type;
        Kenteken = kenteken;
        Kleur = kleur;
        Aanschafjaar = aanschafjaar;
    } */


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