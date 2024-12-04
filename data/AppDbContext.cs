using CarenAll.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CarenAll.data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // voertuigen
    public DbSet<Auto> Autos { get; set; }
    public DbSet<Camper> Campers { get; set; }
    public DbSet<Caravan> Caravans { get; set; }

    // gebruikers
    public DbSet<User> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<PrivateClient> PrivateClients { get; set; }
    public DbSet<CompanyEmployee> CompanyEmployees { get; set; }
    public DbSet<Company> Companies { get; set; }

    // Abbonnementen
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<SubscriptionUpdate> SubscriptionUpdates { get; set; }

    //formulieren
    public DbSet<Leaserequest> LeaseRequests { get; set; }
    public DbSet<DamageReport> DamageReports { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Voertuigen>()
            .HasDiscriminator<string>("VoertuigType")
            .HasValue<Auto>("Auto")
            .HasValue<Camper>("Camper")
            .HasValue<Caravan>("Caravan");

        modelBuilder.Entity<User>()
            .HasDiscriminator<string>("UserType")
            .HasValue<User>("User")
            .HasValue<Employee>("Employee")
            .HasValue<PrivateClient>("PrivateClient")
            .HasValue<CompanyEmployee>("CompanyEmployee")
            .HasValue<Company>("Company");

        modelBuilder.Entity<Company>()
            .HasMany(c => c.CompanyEmployees)
            .WithOne(ce => ce.company)
            .HasForeignKey(ce => ce.CompanyID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CompanyEmployee>()
            .HasOne(ce => ce.company)
            .WithMany(c => c.CompanyEmployees)
            .HasForeignKey(ce => ce.CompanyID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Subscription>()
            .HasMany(s => s.UpdateHistory)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Auto>().HasData(
            new Auto { Id = 1, Merk = "Toyota", Type = "Corolla", Kenteken = "AB-123-CD", Kleur = "Rood", Aanschafjaar = 2018 },
            new Auto { Id = 2, Merk = "Ford", Type = "Focus", Kenteken = "EF-456-GH", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Auto { Id = 3, Merk = "Volkswagen", Type = "Golf", Kenteken = "IJ-789-KL", Kleur = "Zwart", Aanschafjaar = 2020 },
            new Auto { Id = 4, Merk = "Honda", Type = "Civic", Kenteken = "MN-012-OP", Kleur = "Wit", Aanschafjaar = 2017 },
            new Auto { Id = 5, Merk = "BMW", Type = "3 Serie", Kenteken = "QR-345-ST", Kleur = "Grijs", Aanschafjaar = 2021 },
            new Auto { Id = 6, Merk = "Audi", Type = "A4", Kenteken = "UV-678-WX", Kleur = "Zilver", Aanschafjaar = 2016 },
            new Auto { Id = 7, Merk = "Mercedes", Type = "C-Klasse", Kenteken = "YZ-901-AB", Kleur = "Blauw", Aanschafjaar = 2022 },
            new Auto { Id = 8, Merk = "Nissan", Type = "Qashqai", Kenteken = "CD-234-EF", Kleur = "Groen", Aanschafjaar = 2015 },
            new Auto { Id = 9, Merk = "Peugeot", Type = "208", Kenteken = "GH-567-IJ", Kleur = "Rood", Aanschafjaar = 2021 },
            new Auto { Id = 10, Merk = "Renault", Type = "Clio", Kenteken = "KL-890-MN", Kleur = "Zwart", Aanschafjaar = 2018 },
            new Auto { Id = 11, Merk = "Hobby", Type = "De Luxe", Kenteken = "OP-123-QR", Kleur = "Wit", Aanschafjaar = 2017 },
            new Auto { Id = 12, Merk = "Fendt", Type = "Bianco", Kenteken = "ST-456-UV", Kleur = "Grijs", Aanschafjaar = 2018 },
            new Auto { Id = 13, Merk = "Knaus", Type = "Sport", Kenteken = "WX-789-YZ", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Auto { Id = 14, Merk = "Dethleffs", Type = "Camper", Kenteken = "AB-012-CD", Kleur = "Groen", Aanschafjaar = 2016 },
            new Auto { Id = 15, Merk = "Adria", Type = "Altea", Kenteken = "EF-345-GH", Kleur = "Zilver", Aanschafjaar = 2020 },
            new Auto { Id = 16, Merk = "Eriba", Type = "Touring", Kenteken = "IJ-678-KL", Kleur = "Rood", Aanschafjaar = 2015 },
            new Auto { Id = 17, Merk = "Tabbert", Type = "Puccini", Kenteken = "MN-901-OP", Kleur = "Zwart", Aanschafjaar = 2021 },
            new Auto { Id = 18, Merk = "Burstner", Type = "Premio", Kenteken = "QR-234-ST", Kleur = "Wit", Aanschafjaar = 2019 },
            new Auto { Id = 19, Merk = "LMC", Type = "Musica", Kenteken = "UV-567-WX", Kleur = "Blauw", Aanschafjaar = 2018 },
            new Auto { Id = 20, Merk = "Sprite", Type = "Cruzer", Kenteken = "YZ-890-AB", Kleur = "Grijs", Aanschafjaar = 2022 },
            new Auto { Id = 21, Merk = "Volkswagen", Type = "California", Kenteken = "CD-123-EF", Kleur = "Rood", Aanschafjaar = 2018 },
            new Auto { Id = 22, Merk = "Mercedes", Type = "Marco Polo", Kenteken = "GH-456-IJ", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Auto { Id = 23, Merk = "Ford", Type = "Nugget", Kenteken = "KL-789-MN", Kleur = "Zwart", Aanschafjaar = 2020 },
            new Auto { Id = 24, Merk = "Fiat", Type = "Ducato", Kenteken = "OP-012-QR", Kleur = "Wit", Aanschafjaar = 2017 },
            new Auto { Id = 25, Merk = "Citroen", Type = "Jumper", Kenteken = "ST-345-UV", Kleur = "Grijs", Aanschafjaar = 2021 },
            new Auto { Id = 26, Merk = "Peugeot", Type = "Boxer", Kenteken = "WX-678-YZ", Kleur = "Zilver", Aanschafjaar = 2016 },
            new Auto { Id = 27, Merk = "Renault", Type = "Master", Kenteken = "AB-901-CD", Kleur = "Blauw", Aanschafjaar = 2022 },
            new Auto { Id = 28, Merk = "Iveco", Type = "Daily", Kenteken = "EF-234-GH", Kleur = "Groen", Aanschafjaar = 2015 },
            new Auto { Id = 29, Merk = "Opel", Type = "Movano", Kenteken = "IJ-567-KL", Kleur = "Rood", Aanschafjaar = 2021 },
            new Auto { Id = 30, Merk = "Nissan", Type = "NV400", Kenteken = "MN-890-OP", Kleur = "Zwart", Aanschafjaar = 2018 },
            new Auto { Id = 31, Merk = "Kia", Type = "Sportage", Kenteken = "QR-123-ST", Kleur = "Zilver", Aanschafjaar = 2019 },
            new Auto { Id = 32, Merk = "Hyundai", Type = "Tucson", Kenteken = "UV-456-WX", Kleur = "Blauw", Aanschafjaar = 2020 },
            new Auto { Id = 33, Merk = "Skoda", Type = "Octavia", Kenteken = "YZ-789-AB", Kleur = "Groen", Aanschafjaar = 2017 },
            new Auto { Id = 34, Merk = "Mazda", Type = "3", Kenteken = "CD-012-EF", Kleur = "Wit", Aanschafjaar = 2018 },
            new Auto { Id = 35, Merk = "Subaru", Type = "Impreza", Kenteken = "GH-345-IJ", Kleur = "Grijs", Aanschafjaar = 2021 },
            new Auto { Id = 36, Merk = "Suzuki", Type = "Vitara", Kenteken = "KL-678-MN", Kleur = "Zwart", Aanschafjaar = 2019 },
            new Auto { Id = 37, Merk = "Volvo", Type = "XC60", Kenteken = "OP-901-QR", Kleur = "Zilver", Aanschafjaar = 2020 },
            new Auto { Id = 38, Merk = "Mitsubishi", Type = "Outlander", Kenteken = "ST-234-UV", Kleur = "Rood", Aanschafjaar = 2017 },
            new Auto { Id = 39, Merk = "Jeep", Type = "Wrangler", Kenteken = "WX-567-YZ", Kleur = "Groen", Aanschafjaar = 2022 },
            new Auto { Id = 40, Merk = "Land Rover", Type = "Defender", Kenteken = "YZ-890-AB", Kleur = "Blauw", Aanschafjaar = 2021 },
            new Auto { Id = 41, Merk = "Bailey", Type = "Unicorn", Kenteken = "CD-123-EF", Kleur = "Grijs", Aanschafjaar = 2018 },
            new Auto { Id = 42, Merk = "Lunar", Type = "Clubman", Kenteken = "GH-456-IJ", Kleur = "Zwart", Aanschafjaar = 2019 },
            new Auto { Id = 43, Merk = "Swift", Type = "Conqueror", Kenteken = "KL-789-MN", Kleur = "Wit", Aanschafjaar = 2020 },
            new Auto { Id = 44, Merk = "Elddis", Type = "Avante", Kenteken = "OP-012-QR", Kleur = "Zilver", Aanschafjaar = 2017 },
            new Auto { Id = 45, Merk = "Compass", Type = "Casita", Kenteken = "ST-345-UV", Kleur = "Blauw", Aanschafjaar = 2021 },
            new Auto { Id = 46, Merk = "Coachman", Type = "VIP", Kenteken = "WX-678-YZ", Kleur = "Groen", Aanschafjaar = 2016 },
            new Auto { Id = 47, Merk = "Buccaneer", Type = "Commodore", Kenteken = "AB-901-CD", Kleur = "Rood", Aanschafjaar = 2022 },
            new Auto { Id = 48, Merk = "Caravelair", Type = "Allegra", Kenteken = "EF-234-GH", Kleur = "Zwart", Aanschafjaar = 2015 },
            new Auto { Id = 49, Merk = "Sterckeman", Type = "Starlett", Kenteken = "IJ-567-KL", Kleur = "Wit", Aanschafjaar = 2021 },
            new Auto { Id = 50, Merk = "Tab", Type = "320", Kenteken = "MN-890-OP", Kleur = "Grijs", Aanschafjaar = 2018 },
            new Auto { Id = 51, Merk = "Volkswagen", Type = "Grand California", Kenteken = "QR-123-ST", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Auto { Id = 52, Merk = "Mercedes", Type = "Sprinter", Kenteken = "UV-456-WX", Kleur = "Groen", Aanschafjaar = 2020 },
            new Auto { Id = 53, Merk = "Ford", Type = "Transit Custom", Kenteken = "YZ-789-AB", Kleur = "Rood", Aanschafjaar = 2017 },
            new Auto { Id = 54, Merk = "Fiat", Type = "Talento", Kenteken = "CD-012-EF", Kleur = "Zwart", Aanschafjaar = 2018 },
            new Auto { Id = 55, Merk = "Citroen", Type = "SpaceTourer", Kenteken = "GH-345-IJ", Kleur = "Wit", Aanschafjaar = 2021 },
            new Auto { Id = 56, Merk = "Peugeot", Type = "Traveller", Kenteken = "KL-678-MN", Kleur = "Grijs", Aanschafjaar = 2019 },
            new Auto { Id = 57, Merk = "Renault", Type = "Trafic", Kenteken = "OP-901-QR", Kleur = "Blauw", Aanschafjaar = 2020 },
            new Auto { Id = 58, Merk = "Iveco", Type = "Daily", Kenteken = "ST-234-UV", Kleur = "Groen", Aanschafjaar = 2017 },
            new Auto { Id = 59, Merk = "Opel", Type = "Vivaro", Kenteken = "WX-567-YZ", Kleur = "Rood", Aanschafjaar = 2022 },
            new Auto { Id = 60, Merk = "Nissan", Type = "Primastar", Kenteken = "YZ-890-AB", Kleur = "Zwart", Aanschafjaar = 2021 },
            new Auto { Id = 61, Merk = "Toyota", Type = "Yaris", Kenteken = "CD-123-EF", Kleur = "Wit", Aanschafjaar = 2019 },
            new Auto { Id = 62, Merk = "Ford", Type = "Kuga", Kenteken = "GH-456-IJ", Kleur = "Grijs", Aanschafjaar = 2020 },
            new Auto { Id = 63, Merk = "Volkswagen", Type = "Passat", Kenteken = "KL-789-MN", Kleur = "Blauw", Aanschafjaar = 2017 },
            new Auto { Id = 64, Merk = "Honda", Type = "Accord", Kenteken = "OP-012-QR", Kleur = "Groen", Aanschafjaar = 2018 },
            new Auto { Id = 65, Merk = "BMW", Type = "X5", Kenteken = "ST-345-UV", Kleur = "Zilver", Aanschafjaar = 2021 },
            new Auto { Id = 66, Merk = "Audi", Type = "Q7", Kenteken = "WX-678-YZ", Kleur = "Zwart", Aanschafjaar = 2019 },
            new Auto { Id = 67, Merk = "Mercedes", Type = "GLC", Kenteken = "AB-901-CD", Kleur = "Wit", Aanschafjaar = 2020 },
            new Auto { Id = 68, Merk = "Nissan", Type = "Juke", Kenteken = "EF-234-GH", Kleur = "Grijs", Aanschafjaar = 2017 },
            new Auto { Id = 69, Merk = "Peugeot", Type = "308", Kenteken = "IJ-567-KL", Kleur = "Blauw", Aanschafjaar = 2022 },
            new Auto { Id = 70, Merk = "Renault", Type = "Megane", Kenteken = "MN-890-OP", Kleur = "Groen", Aanschafjaar = 2021 },
            new Auto { Id = 71, Merk = "Tabbert", Type = "Rossini", Kenteken = "QR-123-ST", Kleur = "Rood", Aanschafjaar = 2018 },
            new Auto { Id = 72, Merk = "Dethleffs", Type = "Beduin", Kenteken = "UV-456-WX", Kleur = "Zwart", Aanschafjaar = 2019 },
            new Auto { Id = 73, Merk = "Fendt", Type = "Tendenza", Kenteken = "YZ-789-AB", Kleur = "Wit", Aanschafjaar = 2020 },
            new Auto { Id = 74, Merk = "Knaus", Type = "Sudwind", Kenteken = "CD-012-EF", Kleur = "Zilver", Aanschafjaar = 2017 },
            new Auto { Id = 75, Merk = "Hobby", Type = "Excellent", Kenteken = "GH-345-IJ", Kleur = "Blauw", Aanschafjaar = 2021 },
            new Auto { Id = 76, Merk = "Adria", Type = "Action", Kenteken = "KL-678-MN", Kleur = "Groen", Aanschafjaar = 2016 },
            new Auto { Id = 77, Merk = "Eriba", Type = "Feeling", Kenteken = "OP-901-QR", Kleur = "Rood", Aanschafjaar = 2022 },
            new Auto { Id = 78, Merk = "Burstner", Type = "Averso", Kenteken = "ST-234-UV", Kleur = "Zwart", Aanschafjaar = 2015 },
            new Auto { Id = 79, Merk = "LMC", Type = "Vivo", Kenteken = "WX-567-YZ", Kleur = "Wit", Aanschafjaar = 2021 },
            new Auto { Id = 80, Merk = "Sprite", Type = "Major", Kenteken = "YZ-890-AB", Kleur = "Grijs", Aanschafjaar = 2018 },
            new Auto { Id = 81, Merk = "Volkswagen", Type = "Multivan", Kenteken = "CD-123-EF", Kleur = "Zwart", Aanschafjaar = 2019 },
            new Auto { Id = 82, Merk = "Mercedes", Type = "Vito", Kenteken = "GH-456-IJ", Kleur = "Wit", Aanschafjaar = 2020 },
            new Auto { Id = 83, Merk = "Ford", Type = "Custom", Kenteken = "KL-789-MN", Kleur = "Grijs", Aanschafjaar = 2017 },
            new Auto { Id = 84, Merk = "Fiat", Type = "Scudo", Kenteken = "OP-012-QR", Kleur = "Blauw", Aanschafjaar = 2018 },
            new Auto { Id = 85, Merk = "Citroen", Type = "Berlingo", Kenteken = "ST-345-UV", Kleur = "Groen", Aanschafjaar = 2021 },
            new Auto { Id = 86, Merk = "Peugeot", Type = "Partner", Kenteken = "WX-678-YZ", Kleur = "Rood", Aanschafjaar = 2019 },
            new Auto { Id = 87, Merk = "Renault", Type = "Kangoo", Kenteken = "AB-901-CD", Kleur = "Zwart", Aanschafjaar = 2020 },
            new Auto { Id = 88, Merk = "Iveco", Type = "Eurocargo", Kenteken = "EF-234-GH", Kleur = "Wit", Aanschafjaar = 2017 },
            new Auto { Id = 89, Merk = "Opel", Type = "Combo", Kenteken = "IJ-567-KL", Kleur = "Grijs", Aanschafjaar = 2022 },
            new Auto { Id = 90, Merk = "Nissan", Type = "NV200", Kenteken = "MN-890-OP", Kleur = "Blauw", Aanschafjaar = 2021 },
            new Auto { Id = 91, Merk = "Kia", Type = "Picanto", Kenteken = "QR-123-ST", Kleur = "Groen", Aanschafjaar = 2018 },
            new Auto { Id = 92, Merk = "Hyundai", Type = "i30", Kenteken = "UV-456-WX", Kleur = "Rood", Aanschafjaar = 2019 },
            new Auto { Id = 93, Merk = "Skoda", Type = "Superb", Kenteken = "YZ-789-AB", Kleur = "Zwart", Aanschafjaar = 2020 },
            new Auto { Id = 94, Merk = "Mazda", Type = "6", Kenteken = "CD-012-EF", Kleur = "Wit", Aanschafjaar = 2017 },
            new Auto { Id = 95, Merk = "Subaru", Type = "Forester", Kenteken = "GH-345-IJ", Kleur = "Grijs", Aanschafjaar = 2021 },
            new Auto { Id = 96, Merk = "Suzuki", Type = "Swift", Kenteken = "KL-678-MN", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Auto { Id = 97, Merk = "Volvo", Type = "XC90", Kenteken = "OP-901-QR", Kleur = "Groen", Aanschafjaar = 2020 },
            new Auto { Id = 98, Merk = "Mitsubishi", Type = "Eclipse Cross", Kenteken = "ST-234-UV", Kleur = "Rood", Aanschafjaar = 2017 },
            new Auto { Id = 99, Merk = "Jeep", Type = "Renegade", Kenteken = "WX-567-YZ", Kleur = "Zwart", Aanschafjaar = 2022 },
            new Auto { Id = 100, Merk = "Land Rover", Type = "Discovery", Kenteken = "YZ-890-AB", Kleur = "Zilver", Aanschafjaar = 2021 }
        );

        modelBuilder.Entity<Camper>().HasData(
            new Camper { Id = 101, Merk = "Volkswagen", Type = "California", Kenteken = "AB-123-CD", Kleur = "Rood", Aanschafjaar = 2018 },
            new Camper { Id = 102, Merk = "Mercedes", Type = "Marco Polo", Kenteken = "EF-456-GH", Kleur = "Zilver", Aanschafjaar = 2019 },
            new Camper { Id = 103, Merk = "Ford", Type = "Transit Custom", Kenteken = "IJ-789-KL", Kleur = "Blauw", Aanschafjaar = 2020 },
            new Camper { Id = 104, Merk = "Fiat", Type = "Ducato", Kenteken = "MN-012-OP", Kleur = "Wit", Aanschafjaar = 2017 },
            new Camper { Id = 105, Merk = "Citroën", Type = "Jumper", Kenteken = "QR-345-ST", Kleur = "Grijs", Aanschafjaar = 2021 },
            new Camper { Id = 106, Merk = "Peugeot", Type = "Boxer", Kenteken = "UV-678-WX", Kleur = "Zwart", Aanschafjaar = 2016 },
            new Camper { Id = 107, Merk = "Renault", Type = "Master", Kenteken = "YZ-901-AB", Kleur = "Groen", Aanschafjaar = 2022 },
            new Camper { Id = 108, Merk = "Nissan", Type = "NV400", Kenteken = "CD-234-EF", Kleur = "Blauw", Aanschafjaar = 2015 },
            new Camper { Id = 109, Merk = "Opel", Type = "Movano", Kenteken = "GH-567-IJ", Kleur = "Zilver", Aanschafjaar = 2021 },
            new Camper { Id = 110, Merk = "Iveco", Type = "Daily", Kenteken = "KL-890-MN", Kleur = "Rood", Aanschafjaar = 2018 },
            new Camper { Id = 111, Merk = "Volkswagen", Type = "Grand California", Kenteken = "OP-123-QR", Kleur = "Wit", Aanschafjaar = 2017 },
            new Camper { Id = 112, Merk = "Mercedes", Type = "Sprinter", Kenteken = "ST-456-UV", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Camper { Id = 113, Merk = "Ford", Type = "Nugget", Kenteken = "WX-789-YZ", Kleur = "Zwart", Aanschafjaar = 2020 },
            new Camper { Id = 114, Merk = "Fiat", Type = "Talento", Kenteken = "AB-012-CD", Kleur = "Groen", Aanschafjaar = 2016 },
            new Camper { Id = 115, Merk = "Citroën", Type = "SpaceTourer", Kenteken = "EF-345-GH", Kleur = "Rood", Aanschafjaar = 2018 },
            new Camper { Id = 116, Merk = "Peugeot", Type = "Traveller", Kenteken = "IJ-678-KL", Kleur = "Zwart", Aanschafjaar = 2021 },
            new Camper { Id = 117, Merk = "Renault", Type = "Trafic", Kenteken = "MN-901-OP", Kleur = "Wit", Aanschafjaar = 2020 },
            new Camper { Id = 118, Merk = "Nissan", Type = "Primastar", Kenteken = "QR-234-ST", Kleur = "Zilver", Aanschafjaar = 2019 },
            new Camper { Id = 119, Merk = "Opel", Type = "Vivaro", Kenteken = "UV-567-WX", Kleur = "Grijs", Aanschafjaar = 2022 },
            new Camper { Id = 120, Merk = "Iveco", Type = "Eurocargo", Kenteken = "YZ-890-AB", Kleur = "Zwart", Aanschafjaar = 2017 },
            new Camper { Id = 121, Merk = "Volkswagen", Type = "Multivan", Kenteken = "CD-123-EF", Kleur = "Blauw", Aanschafjaar = 2018 },
            new Camper { Id = 122, Merk = "Mercedes", Type = "Vito", Kenteken = "GH-456-IJ", Kleur = "Groen", Aanschafjaar = 2020 },
            new Camper { Id = 123, Merk = "Ford", Type = "Kuga Camper", Kenteken = "KL-789-MN", Kleur = "Zilver", Aanschafjaar = 2017 },
            new Camper { Id = 124, Merk = "Fiat", Type = "Scudo", Kenteken = "OP-012-QR", Kleur = "Rood", Aanschafjaar = 2018 },
            new Camper { Id = 125, Merk = "Citroën", Type = "Berlingo", Kenteken = "ST-345-UV", Kleur = "Wit", Aanschafjaar = 2019 },
            new Camper { Id = 126, Merk = "Peugeot", Type = "Expert Camper", Kenteken = "WX-678-YZ", Kleur = "Grijs", Aanschafjaar = 2016 },
            new Camper { Id = 127, Merk = "Renault", Type = "Kangoo Camper", Kenteken = "AB-901-CD", Kleur = "Blauw", Aanschafjaar = 2022 },
            new Camper { Id = 128, Merk = "Nissan", Type = "Juke Camper", Kenteken = "EF-234-GH", Kleur = "Zwart", Aanschafjaar = 2015 },
            new Camper { Id = 129, Merk = "Opel", Type = "Zafira Camper", Kenteken = "GH-567-IJ", Kleur = "Groen", Aanschafjaar = 2021 },
            new Camper { Id = 130, Merk = "Iveco", Type = "Camper 2000", Kenteken = "KL-890-MN", Kleur = "Rood", Aanschafjaar = 2018 },
            new Camper { Id = 131, Merk = "Volkswagen", Type = "Kombi", Kenteken = "OP-123-QR", Kleur = "Zwart", Aanschafjaar = 2017 },
            new Camper { Id = 132, Merk = "Mercedes", Type = "Sprinter XXL", Kenteken = "ST-456-UV", Kleur = "Zilver", Aanschafjaar = 2021 },
            new Camper { Id = 133, Merk = "Ford", Type = "Custom Camper", Kenteken = "WX-789-YZ", Kleur = "Blauw", Aanschafjaar = 2020 },
            new Camper { Id = 134, Merk = "Fiat", Type = "Ducato Maxi", Kenteken = "AB-012-CD", Kleur = "Wit", Aanschafjaar = 2016 },
            new Camper { Id = 135, Merk = "Citroën", Type = "Jumper Camper", Kenteken = "EF-345-GH", Kleur = "Groen", Aanschafjaar = 2018 },
            new Camper { Id = 136, Merk = "Peugeot", Type = "Boxer XL", Kenteken = "IJ-678-KL", Kleur = "Zwart", Aanschafjaar = 2021 },
            new Camper { Id = 137, Merk = "Renault", Type = "Master Pro", Kenteken = "MN-901-OP", Kleur = "Grijs", Aanschafjaar = 2019 },
            new Camper { Id = 138, Merk = "Nissan", Type = "NV300 Camper", Kenteken = "QR-234-ST", Kleur = "Blauw", Aanschafjaar = 2022 },
            new Camper { Id = 139, Merk = "Opel", Type = "Vivaro XL", Kenteken = "UV-567-WX", Kleur = "Zilver", Aanschafjaar = 2017 },
            new Camper { Id = 140, Merk = "Iveco", Type = "Daily Pro", Kenteken = "YZ-890-AB", Kleur = "Rood", Aanschafjaar = 2018 },
            new Camper { Id = 141, Merk = "Volkswagen", Type = "T6 California", Kenteken = "CD-123-EF", Kleur = "Groen", Aanschafjaar = 2020 },
            new Camper { Id = 142, Merk = "Mercedes", Type = "V-Class Camper", Kenteken = "GH-456-IJ", Kleur = "Zwart", Aanschafjaar = 2019 },
            new Camper { Id = 143, Merk = "Ford", Type = "Transit Nugget Plus", Kenteken = "KL-789-MN", Kleur = "Wit", Aanschafjaar = 2022 }
        );

        modelBuilder.Entity<Caravan>().HasData(
            new Caravan { Id = 201, Merk = "Hobby", Type = "De Luxe", Kenteken = "AB-123-CD", Kleur = "Wit", Aanschafjaar = 2018 },
            new Caravan { Id = 202, Merk = "Fendt", Type = "Bianco", Kenteken = "EF-456-GH", Kleur = "Grijs", Aanschafjaar = 2019 },
            new Caravan { Id = 203, Merk = "Knaus", Type = "Sport", Kenteken = "IJ-789-KL", Kleur = "Blauw", Aanschafjaar = 2020 },
            new Caravan { Id = 204, Merk = "Adria", Type = "Altea", Kenteken = "MN-012-OP", Kleur = "Zilver", Aanschafjaar = 2017 },
            new Caravan { Id = 205, Merk = "Dethleffs", Type = "Camper", Kenteken = "QR-345-ST", Kleur = "Groen", Aanschafjaar = 2021 },
            new Caravan { Id = 206, Merk = "Tabbert", Type = "Puccini", Kenteken = "UV-678-WX", Kleur = "Zwart", Aanschafjaar = 2016 },
            new Caravan { Id = 207, Merk = "Burstner", Type = "Premio", Kenteken = "YZ-901-AB", Kleur = "Wit", Aanschafjaar = 2022 },
            new Caravan { Id = 208, Merk = "LMC", Type = "Musica", Kenteken = "CD-234-EF", Kleur = "Blauw", Aanschafjaar = 2015 },
            new Caravan { Id = 209, Merk = "Sprite", Type = "Cruzer", Kenteken = "GH-567-IJ", Kleur = "Rood", Aanschafjaar = 2021 },
            new Caravan { Id = 210, Merk = "Bailey", Type = "Unicorn", Kenteken = "KL-890-MN", Kleur = "Grijs", Aanschafjaar = 2018 },
            new Caravan { Id = 211, Merk = "Lunar", Type = "Clubman", Kenteken = "OP-123-QR", Kleur = "Zilver", Aanschafjaar = 2017 },
            new Caravan { Id = 212, Merk = "Swift", Type = "Conqueror", Kenteken = "ST-456-UV", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Caravan { Id = 213, Merk = "Compass", Type = "Casita", Kenteken = "WX-789-YZ", Kleur = "Groen", Aanschafjaar = 2020 },
            new Caravan { Id = 214, Merk = "Coachman", Type = "VIP", Kenteken = "AB-012-CD", Kleur = "Rood", Aanschafjaar = 2016 },
            new Caravan { Id = 215, Merk = "Buccaneer", Type = "Commodore", Kenteken = "EF-345-GH", Kleur = "Zwart", Aanschafjaar = 2018 },
            new Caravan { Id = 216, Merk = "Caravelair", Type = "Allegra", Kenteken = "IJ-678-KL", Kleur = "Wit", Aanschafjaar = 2021 },
            new Caravan { Id = 217, Merk = "Sterckeman", Type = "Starlett", Kenteken = "MN-901-OP", Kleur = "Zilver", Aanschafjaar = 2020 },
            new Caravan { Id = 218, Merk = "Tab", Type = "320", Kenteken = "QR-234-ST", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Caravan { Id = 219, Merk = "Eriba", Type = "Touring", Kenteken = "UV-567-WX", Kleur = "Grijs", Aanschafjaar = 2022 },
            new Caravan { Id = 220, Merk = "Adria", Type = "Action", Kenteken = "YZ-890-AB", Kleur = "Rood", Aanschafjaar = 2017 },
            new Caravan { Id = 221, Merk = "Fendt", Type = "Tendenza", Kenteken = "CD-123-EF", Kleur = "Wit", Aanschafjaar = 2018 },
            new Caravan { Id = 222, Merk = "Knaus", Type = "Sudwind", Kenteken = "GH-456-IJ", Kleur = "Groen", Aanschafjaar = 2020 },
            new Caravan { Id = 223, Merk = "Hobby", Type = "Excellent", Kenteken = "KL-789-MN", Kleur = "Zwart", Aanschafjaar = 2017 },
            new Caravan { Id = 224, Merk = "Dethleffs", Type = "Beduin", Kenteken = "OP-012-QR", Kleur = "Blauw", Aanschafjaar = 2019 },
            new Caravan { Id = 225, Merk = "Burstner", Type = "Averso", Kenteken = "ST-345-UV", Kleur = "Zilver", Aanschafjaar = 2021 },
            new Caravan { Id = 226, Merk = "LMC", Type = "Vivo", Kenteken = "WX-678-YZ", Kleur = "Rood", Aanschafjaar = 2020 },
            new Caravan { Id = 227, Merk = "Sprite", Type = "Major", Kenteken = "AB-901-CD", Kleur = "Groen", Aanschafjaar = 2019 },
            new Caravan { Id = 228, Merk = "Bailey", Type = "Phoenix", Kenteken = "EF-234-GH", Kleur = "Wit", Aanschafjaar = 2022 },
            new Caravan { Id = 229, Merk = "Lunar", Type = "Delta", Kenteken = "GH-567-IJ", Kleur = "Grijs", Aanschafjaar = 2017 },
            new Caravan { Id = 230, Merk = "Swift", Type = "Elegance", Kenteken = "KL-890-MN", Kleur = "Zwart", Aanschafjaar = 2018 },
            new Caravan { Id = 231, Merk = "Compass", Type = "Corona", Kenteken = "OP-123-QR", Kleur = "Blauw", Aanschafjaar = 2021 },
            new Caravan { Id = 232, Merk = "Coachman", Type = "Acadia", Kenteken = "ST-456-UV", Kleur = "Zilver", Aanschafjaar = 2019 },
            new Caravan { Id = 233, Merk = "Buccaneer", Type = "Barracuda", Kenteken = "WX-789-YZ", Kleur = "Rood", Aanschafjaar = 2020 },
            new Caravan { Id = 234, Merk = "Caravelair", Type = "Antares", Kenteken = "AB-012-CD", Kleur = "Groen", Aanschafjaar = 2016 },
            new Caravan { Id = 235, Merk = "Sterckeman", Type = "Evolution", Kenteken = "EF-345-GH", Kleur = "Zwart", Aanschafjaar = 2018 },
            new Caravan { Id = 236, Merk = "Tab", Type = "400", Kenteken = "IJ-678-KL", Kleur = "Zilver", Aanschafjaar = 2021 },
            new Caravan { Id = 237, Merk = "Eriba", Type = "Nova", Kenteken = "MN-901-OP", Kleur = "Blauw", Aanschafjaar = 2020 },
            new Caravan { Id = 238, Merk = "Adria", Type = "Adora", Kenteken = "QR-234-ST", Kleur = "Wit", Aanschafjaar = 2019 },
            new Caravan { Id = 239, Merk = "Fendt", Type = "Opal", Kenteken = "UV-567-WX", Kleur = "Zwart", Aanschafjaar = 2022 },
            new Caravan { Id = 240, Merk = "Knaus", Type = "Sky Traveller", Kenteken = "YZ-890-AB", Kleur = "Groen", Aanschafjaar = 2017 },
            new Caravan { Id = 241, Merk = "Hobby", Type = "Prestige", Kenteken = "CD-123-EF", Kleur = "Grijs", Aanschafjaar = 2018 },
            new Caravan { Id = 242, Merk = "Dethleffs", Type = "C'go", Kenteken = "GH-456-IJ", Kleur = "Blauw", Aanschafjaar = 2020 },
            new Caravan { Id = 243, Merk = "Burstner", Type = "Premio Life", Kenteken = "KL-789-MN", Kleur = "Rood", Aanschafjaar = 2017 }
        );

    }
}