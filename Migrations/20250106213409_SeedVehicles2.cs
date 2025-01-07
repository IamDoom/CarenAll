using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarenAll.Migrations
{
    /// <inheritdoc />
    public partial class SeedVehicles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Aanschafjaar", "Kenteken", "Kleur", "Merk", "Type", "VoertuigType" },
                values: new object[,]
                {
                    { 1, 2018, "AB-123-CD", "Rood", "Toyota", "Corolla", "Auto" },
                    { 2, 2019, "EF-456-GH", "Blauw", "Ford", "Focus", "Auto" },
                    { 3, 2020, "IJ-789-KL", "Zwart", "Volkswagen", "Golf", "Auto" },
                    { 4, 2017, "MN-012-OP", "Wit", "Honda", "Civic", "Auto" },
                    { 5, 2021, "QR-345-ST", "Grijs", "BMW", "3 Serie", "Auto" },
                    { 6, 2016, "UV-678-WX", "Zilver", "Audi", "A4", "Auto" },
                    { 7, 2022, "YZ-901-AB", "Blauw", "Mercedes", "C-Klasse", "Auto" },
                    { 8, 2015, "CD-234-EF", "Groen", "Nissan", "Qashqai", "Auto" },
                    { 9, 2021, "GH-567-IJ", "Rood", "Peugeot", "208", "Auto" },
                    { 10, 2018, "KL-890-MN", "Zwart", "Renault", "Clio", "Auto" },
                    { 11, 2017, "OP-123-QR", "Wit", "Hobby", "De Luxe", "Auto" },
                    { 12, 2018, "ST-456-UV", "Grijs", "Fendt", "Bianco", "Auto" },
                    { 13, 2019, "WX-789-YZ", "Blauw", "Knaus", "Sport", "Auto" },
                    { 14, 2016, "AB-012-CD", "Groen", "Dethleffs", "Camper", "Auto" },
                    { 15, 2020, "EF-345-GH", "Zilver", "Adria", "Altea", "Auto" },
                    { 16, 2015, "IJ-678-KL", "Rood", "Eriba", "Touring", "Auto" },
                    { 17, 2021, "MN-901-OP", "Zwart", "Tabbert", "Puccini", "Auto" },
                    { 18, 2019, "QR-234-ST", "Wit", "Burstner", "Premio", "Auto" },
                    { 19, 2018, "UV-567-WX", "Blauw", "LMC", "Musica", "Auto" },
                    { 20, 2022, "YZ-890-AB", "Grijs", "Sprite", "Cruzer", "Auto" },
                    { 21, 2018, "CD-123-EF", "Rood", "Volkswagen", "California", "Auto" },
                    { 22, 2019, "GH-456-IJ", "Blauw", "Mercedes", "Marco Polo", "Auto" },
                    { 23, 2020, "KL-789-MN", "Zwart", "Ford", "Nugget", "Auto" },
                    { 24, 2017, "OP-012-QR", "Wit", "Fiat", "Ducato", "Auto" },
                    { 25, 2021, "ST-345-UV", "Grijs", "Citroen", "Jumper", "Auto" },
                    { 26, 2016, "WX-678-YZ", "Zilver", "Peugeot", "Boxer", "Auto" },
                    { 27, 2022, "AB-901-CD", "Blauw", "Renault", "Master", "Auto" },
                    { 28, 2015, "EF-234-GH", "Groen", "Iveco", "Daily", "Auto" },
                    { 29, 2021, "IJ-567-KL", "Rood", "Opel", "Movano", "Auto" },
                    { 30, 2018, "MN-890-OP", "Zwart", "Nissan", "NV400", "Auto" },
                    { 31, 2019, "QR-123-ST", "Zilver", "Kia", "Sportage", "Auto" },
                    { 32, 2020, "UV-456-WX", "Blauw", "Hyundai", "Tucson", "Auto" },
                    { 33, 2017, "YZ-789-AB", "Groen", "Skoda", "Octavia", "Auto" },
                    { 34, 2018, "CD-012-EF", "Wit", "Mazda", "3", "Auto" },
                    { 35, 2021, "GH-345-IJ", "Grijs", "Subaru", "Impreza", "Auto" },
                    { 36, 2019, "KL-678-MN", "Zwart", "Suzuki", "Vitara", "Auto" },
                    { 37, 2020, "OP-901-QR", "Zilver", "Volvo", "XC60", "Auto" },
                    { 38, 2017, "ST-234-UV", "Rood", "Mitsubishi", "Outlander", "Auto" },
                    { 39, 2022, "WX-567-YZ", "Groen", "Jeep", "Wrangler", "Auto" },
                    { 40, 2021, "YZ-890-AB", "Blauw", "Land Rover", "Defender", "Auto" },
                    { 41, 2018, "CD-123-EF", "Grijs", "Bailey", "Unicorn", "Auto" },
                    { 42, 2019, "GH-456-IJ", "Zwart", "Lunar", "Clubman", "Auto" },
                    { 43, 2020, "KL-789-MN", "Wit", "Swift", "Conqueror", "Auto" },
                    { 44, 2017, "OP-012-QR", "Zilver", "Elddis", "Avante", "Auto" },
                    { 45, 2021, "ST-345-UV", "Blauw", "Compass", "Casita", "Auto" },
                    { 46, 2016, "WX-678-YZ", "Groen", "Coachman", "VIP", "Auto" },
                    { 47, 2022, "AB-901-CD", "Rood", "Buccaneer", "Commodore", "Auto" },
                    { 48, 2015, "EF-234-GH", "Zwart", "Caravelair", "Allegra", "Auto" },
                    { 49, 2021, "IJ-567-KL", "Wit", "Sterckeman", "Starlett", "Auto" },
                    { 50, 2018, "MN-890-OP", "Grijs", "Tab", "320", "Auto" },
                    { 51, 2019, "QR-123-ST", "Blauw", "Volkswagen", "Grand California", "Auto" },
                    { 52, 2020, "UV-456-WX", "Groen", "Mercedes", "Sprinter", "Auto" },
                    { 53, 2017, "YZ-789-AB", "Rood", "Ford", "Transit Custom", "Auto" },
                    { 54, 2018, "CD-012-EF", "Zwart", "Fiat", "Talento", "Auto" },
                    { 55, 2021, "GH-345-IJ", "Wit", "Citroen", "SpaceTourer", "Auto" },
                    { 56, 2019, "KL-678-MN", "Grijs", "Peugeot", "Traveller", "Auto" },
                    { 57, 2020, "OP-901-QR", "Blauw", "Renault", "Trafic", "Auto" },
                    { 58, 2017, "ST-234-UV", "Groen", "Iveco", "Daily", "Auto" },
                    { 59, 2022, "WX-567-YZ", "Rood", "Opel", "Vivaro", "Auto" },
                    { 60, 2021, "YZ-890-AB", "Zwart", "Nissan", "Primastar", "Auto" },
                    { 61, 2019, "CD-123-EF", "Wit", "Toyota", "Yaris", "Auto" },
                    { 62, 2020, "GH-456-IJ", "Grijs", "Ford", "Kuga", "Auto" },
                    { 63, 2017, "KL-789-MN", "Blauw", "Volkswagen", "Passat", "Auto" },
                    { 64, 2018, "OP-012-QR", "Groen", "Honda", "Accord", "Auto" },
                    { 65, 2021, "ST-345-UV", "Zilver", "BMW", "X5", "Auto" },
                    { 66, 2019, "WX-678-YZ", "Zwart", "Audi", "Q7", "Auto" },
                    { 67, 2020, "AB-901-CD", "Wit", "Mercedes", "GLC", "Auto" },
                    { 68, 2017, "EF-234-GH", "Grijs", "Nissan", "Juke", "Auto" },
                    { 69, 2022, "IJ-567-KL", "Blauw", "Peugeot", "308", "Auto" },
                    { 70, 2021, "MN-890-OP", "Groen", "Renault", "Megane", "Auto" },
                    { 71, 2018, "QR-123-ST", "Rood", "Tabbert", "Rossini", "Auto" },
                    { 72, 2019, "UV-456-WX", "Zwart", "Dethleffs", "Beduin", "Auto" },
                    { 73, 2020, "YZ-789-AB", "Wit", "Fendt", "Tendenza", "Auto" },
                    { 74, 2017, "CD-012-EF", "Zilver", "Knaus", "Sudwind", "Auto" },
                    { 75, 2021, "GH-345-IJ", "Blauw", "Hobby", "Excellent", "Auto" },
                    { 76, 2016, "KL-678-MN", "Groen", "Adria", "Action", "Auto" },
                    { 77, 2022, "OP-901-QR", "Rood", "Eriba", "Feeling", "Auto" },
                    { 78, 2015, "ST-234-UV", "Zwart", "Burstner", "Averso", "Auto" },
                    { 79, 2021, "WX-567-YZ", "Wit", "LMC", "Vivo", "Auto" },
                    { 80, 2018, "YZ-890-AB", "Grijs", "Sprite", "Major", "Auto" },
                    { 81, 2019, "CD-123-EF", "Zwart", "Volkswagen", "Multivan", "Auto" },
                    { 82, 2020, "GH-456-IJ", "Wit", "Mercedes", "Vito", "Auto" },
                    { 83, 2017, "KL-789-MN", "Grijs", "Ford", "Custom", "Auto" },
                    { 84, 2018, "OP-012-QR", "Blauw", "Fiat", "Scudo", "Auto" },
                    { 85, 2021, "ST-345-UV", "Groen", "Citroen", "Berlingo", "Auto" },
                    { 86, 2019, "WX-678-YZ", "Rood", "Peugeot", "Partner", "Auto" },
                    { 87, 2020, "AB-901-CD", "Zwart", "Renault", "Kangoo", "Auto" },
                    { 88, 2017, "EF-234-GH", "Wit", "Iveco", "Eurocargo", "Auto" },
                    { 89, 2022, "IJ-567-KL", "Grijs", "Opel", "Combo", "Auto" },
                    { 90, 2021, "MN-890-OP", "Blauw", "Nissan", "NV200", "Auto" },
                    { 91, 2018, "QR-123-ST", "Groen", "Kia", "Picanto", "Auto" },
                    { 92, 2019, "UV-456-WX", "Rood", "Hyundai", "i30", "Auto" },
                    { 93, 2020, "YZ-789-AB", "Zwart", "Skoda", "Superb", "Auto" },
                    { 94, 2017, "CD-012-EF", "Wit", "Mazda", "6", "Auto" },
                    { 95, 2021, "GH-345-IJ", "Grijs", "Subaru", "Forester", "Auto" },
                    { 96, 2019, "KL-678-MN", "Blauw", "Suzuki", "Swift", "Auto" },
                    { 97, 2020, "OP-901-QR", "Groen", "Volvo", "XC90", "Auto" },
                    { 98, 2017, "ST-234-UV", "Rood", "Mitsubishi", "Eclipse Cross", "Auto" },
                    { 99, 2022, "WX-567-YZ", "Zwart", "Jeep", "Renegade", "Auto" },
                    { 100, 2021, "YZ-890-AB", "Zilver", "Land Rover", "Discovery", "Auto" },
                    { 101, 2018, "AB-123-CD", "Rood", "Volkswagen", "California", "Camper" },
                    { 102, 2019, "EF-456-GH", "Zilver", "Mercedes", "Marco Polo", "Camper" },
                    { 103, 2020, "IJ-789-KL", "Blauw", "Ford", "Transit Custom", "Camper" },
                    { 104, 2017, "MN-012-OP", "Wit", "Fiat", "Ducato", "Camper" },
                    { 105, 2021, "QR-345-ST", "Grijs", "Citroën", "Jumper", "Camper" },
                    { 106, 2016, "UV-678-WX", "Zwart", "Peugeot", "Boxer", "Camper" },
                    { 107, 2022, "YZ-901-AB", "Groen", "Renault", "Master", "Camper" },
                    { 108, 2015, "CD-234-EF", "Blauw", "Nissan", "NV400", "Camper" },
                    { 109, 2021, "GH-567-IJ", "Zilver", "Opel", "Movano", "Camper" },
                    { 110, 2018, "KL-890-MN", "Rood", "Iveco", "Daily", "Camper" },
                    { 111, 2017, "OP-123-QR", "Wit", "Volkswagen", "Grand California", "Camper" },
                    { 112, 2019, "ST-456-UV", "Blauw", "Mercedes", "Sprinter", "Camper" },
                    { 113, 2020, "WX-789-YZ", "Zwart", "Ford", "Nugget", "Camper" },
                    { 114, 2016, "AB-012-CD", "Groen", "Fiat", "Talento", "Camper" },
                    { 115, 2018, "EF-345-GH", "Rood", "Citroën", "SpaceTourer", "Camper" },
                    { 116, 2021, "IJ-678-KL", "Zwart", "Peugeot", "Traveller", "Camper" },
                    { 117, 2020, "MN-901-OP", "Wit", "Renault", "Trafic", "Camper" },
                    { 118, 2019, "QR-234-ST", "Zilver", "Nissan", "Primastar", "Camper" },
                    { 119, 2022, "UV-567-WX", "Grijs", "Opel", "Vivaro", "Camper" },
                    { 120, 2017, "YZ-890-AB", "Zwart", "Iveco", "Eurocargo", "Camper" },
                    { 121, 2018, "CD-123-EF", "Blauw", "Volkswagen", "Multivan", "Camper" },
                    { 122, 2020, "GH-456-IJ", "Groen", "Mercedes", "Vito", "Camper" },
                    { 123, 2017, "KL-789-MN", "Zilver", "Ford", "Kuga Camper", "Camper" },
                    { 124, 2018, "OP-012-QR", "Rood", "Fiat", "Scudo", "Camper" },
                    { 125, 2019, "ST-345-UV", "Wit", "Citroën", "Berlingo", "Camper" },
                    { 126, 2016, "WX-678-YZ", "Grijs", "Peugeot", "Expert Camper", "Camper" },
                    { 127, 2022, "AB-901-CD", "Blauw", "Renault", "Kangoo Camper", "Camper" },
                    { 128, 2015, "EF-234-GH", "Zwart", "Nissan", "Juke Camper", "Camper" },
                    { 129, 2021, "GH-567-IJ", "Groen", "Opel", "Zafira Camper", "Camper" },
                    { 130, 2018, "KL-890-MN", "Rood", "Iveco", "Camper 2000", "Camper" },
                    { 131, 2017, "OP-123-QR", "Zwart", "Volkswagen", "Kombi", "Camper" },
                    { 132, 2021, "ST-456-UV", "Zilver", "Mercedes", "Sprinter XXL", "Camper" },
                    { 133, 2020, "WX-789-YZ", "Blauw", "Ford", "Custom Camper", "Camper" },
                    { 134, 2016, "AB-012-CD", "Wit", "Fiat", "Ducato Maxi", "Camper" },
                    { 135, 2018, "EF-345-GH", "Groen", "Citroën", "Jumper Camper", "Camper" },
                    { 136, 2021, "IJ-678-KL", "Zwart", "Peugeot", "Boxer XL", "Camper" },
                    { 137, 2019, "MN-901-OP", "Grijs", "Renault", "Master Pro", "Camper" },
                    { 138, 2022, "QR-234-ST", "Blauw", "Nissan", "NV300 Camper", "Camper" },
                    { 139, 2017, "UV-567-WX", "Zilver", "Opel", "Vivaro XL", "Camper" },
                    { 140, 2018, "YZ-890-AB", "Rood", "Iveco", "Daily Pro", "Camper" },
                    { 141, 2020, "CD-123-EF", "Groen", "Volkswagen", "T6 California", "Camper" },
                    { 142, 2019, "GH-456-IJ", "Zwart", "Mercedes", "V-Class Camper", "Camper" },
                    { 143, 2022, "KL-789-MN", "Wit", "Ford", "Transit Nugget Plus", "Camper" },
                    { 201, 2018, "AB-123-CD", "Wit", "Hobby", "De Luxe", "Caravan" },
                    { 202, 2019, "EF-456-GH", "Grijs", "Fendt", "Bianco", "Caravan" },
                    { 203, 2020, "IJ-789-KL", "Blauw", "Knaus", "Sport", "Caravan" },
                    { 204, 2017, "MN-012-OP", "Zilver", "Adria", "Altea", "Caravan" },
                    { 205, 2021, "QR-345-ST", "Groen", "Dethleffs", "Camper", "Caravan" },
                    { 206, 2016, "UV-678-WX", "Zwart", "Tabbert", "Puccini", "Caravan" },
                    { 207, 2022, "YZ-901-AB", "Wit", "Burstner", "Premio", "Caravan" },
                    { 208, 2015, "CD-234-EF", "Blauw", "LMC", "Musica", "Caravan" },
                    { 209, 2021, "GH-567-IJ", "Rood", "Sprite", "Cruzer", "Caravan" },
                    { 210, 2018, "KL-890-MN", "Grijs", "Bailey", "Unicorn", "Caravan" },
                    { 211, 2017, "OP-123-QR", "Zilver", "Lunar", "Clubman", "Caravan" },
                    { 212, 2019, "ST-456-UV", "Blauw", "Swift", "Conqueror", "Caravan" },
                    { 213, 2020, "WX-789-YZ", "Groen", "Compass", "Casita", "Caravan" },
                    { 214, 2016, "AB-012-CD", "Rood", "Coachman", "VIP", "Caravan" },
                    { 215, 2018, "EF-345-GH", "Zwart", "Buccaneer", "Commodore", "Caravan" },
                    { 216, 2021, "IJ-678-KL", "Wit", "Caravelair", "Allegra", "Caravan" },
                    { 217, 2020, "MN-901-OP", "Zilver", "Sterckeman", "Starlett", "Caravan" },
                    { 218, 2019, "QR-234-ST", "Blauw", "Tab", "320", "Caravan" },
                    { 219, 2022, "UV-567-WX", "Grijs", "Eriba", "Touring", "Caravan" },
                    { 220, 2017, "YZ-890-AB", "Rood", "Adria", "Action", "Caravan" },
                    { 221, 2018, "CD-123-EF", "Wit", "Fendt", "Tendenza", "Caravan" },
                    { 222, 2020, "GH-456-IJ", "Groen", "Knaus", "Sudwind", "Caravan" },
                    { 223, 2017, "KL-789-MN", "Zwart", "Hobby", "Excellent", "Caravan" },
                    { 224, 2019, "OP-012-QR", "Blauw", "Dethleffs", "Beduin", "Caravan" },
                    { 225, 2021, "ST-345-UV", "Zilver", "Burstner", "Averso", "Caravan" },
                    { 226, 2020, "WX-678-YZ", "Rood", "LMC", "Vivo", "Caravan" },
                    { 227, 2019, "AB-901-CD", "Groen", "Sprite", "Major", "Caravan" },
                    { 228, 2022, "EF-234-GH", "Wit", "Bailey", "Phoenix", "Caravan" },
                    { 229, 2017, "GH-567-IJ", "Grijs", "Lunar", "Delta", "Caravan" },
                    { 230, 2018, "KL-890-MN", "Zwart", "Swift", "Elegance", "Caravan" },
                    { 231, 2021, "OP-123-QR", "Blauw", "Compass", "Corona", "Caravan" },
                    { 232, 2019, "ST-456-UV", "Zilver", "Coachman", "Acadia", "Caravan" },
                    { 233, 2020, "WX-789-YZ", "Rood", "Buccaneer", "Barracuda", "Caravan" },
                    { 234, 2016, "AB-012-CD", "Groen", "Caravelair", "Antares", "Caravan" },
                    { 235, 2018, "EF-345-GH", "Zwart", "Sterckeman", "Evolution", "Caravan" },
                    { 236, 2021, "IJ-678-KL", "Zilver", "Tab", "400", "Caravan" },
                    { 237, 2020, "MN-901-OP", "Blauw", "Eriba", "Nova", "Caravan" },
                    { 238, 2019, "QR-234-ST", "Wit", "Adria", "Adora", "Caravan" },
                    { 239, 2022, "UV-567-WX", "Zwart", "Fendt", "Opal", "Caravan" },
                    { 240, 2017, "YZ-890-AB", "Groen", "Knaus", "Sky Traveller", "Caravan" },
                    { 241, 2018, "CD-123-EF", "Grijs", "Hobby", "Prestige", "Caravan" },
                    { 242, 2020, "GH-456-IJ", "Blauw", "Dethleffs", "C'go", "Caravan" },
                    { 243, 2017, "KL-789-MN", "Rood", "Burstner", "Premio Life", "Caravan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 243);
        }
    }
}
