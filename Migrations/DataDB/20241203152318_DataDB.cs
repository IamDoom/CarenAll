using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarenAll.Migrations.DataDB
{
    /// <inheritdoc />
    public partial class DataDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCandidates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bedrijfsNaam = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    kvkNummer = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCandidates", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCandidates");
        }
    }
}
