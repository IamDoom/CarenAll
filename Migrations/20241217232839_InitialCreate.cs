using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarenAll.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubcriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Upfront = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubcriptionID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Merk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kenteken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aanschafjaar = table.Column<int>(type: "int", nullable: false),
                    VoertuigType = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kvk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionID = table.Column<int>(type: "int", nullable: true),
                    CompanyEmployeeID = table.Column<int>(type: "int", nullable: true),
                    EmployerID = table.Column<int>(type: "int", nullable: true),
                    CompanyEmployee_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmployee_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: true),
                    Employee_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employee_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateClientID = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyEmployees",
                        column: x => x.EmployerID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Subscriptions_SubscriptionID",
                        column: x => x.SubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "SubcriptionID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "DamageReports",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReporterID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageReports", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_DamageReports_Users_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DamageReports_Users_ReporterID",
                        column: x => x.ReporterID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DamageReports_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaseRequests",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestorID = table.Column<int>(type: "int", nullable: false),
                    RequestorCompanyID = table.Column<int>(type: "int", nullable: true),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedDistanceInKM = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseRequests", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_LeaseRequest_Company_CompanyID",
                        column: x => x.RequestorCompanyID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_LeaseRequest_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaseRequest_Requestor_RequestorID",
                        column: x => x.RequestorID,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaseRequest_Vehicle_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaseRequests_Users_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionUpdates",
                columns: table => new
                {
                    UpdateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedByEmployeeID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionSubcriptionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionUpdates", x => x.UpdateID);
                    table.ForeignKey(
                        name: "FK_SubscriptionUpdates_Subscriptions_SubscriptionSubcriptionID",
                        column: x => x.SubscriptionSubcriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "SubcriptionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionUpdates_Users_UpdatedByEmployeeID",
                        column: x => x.UpdatedByEmployeeID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DamageReports_DriverID",
                table: "DamageReports",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_DamageReports_ReporterID",
                table: "DamageReports",
                column: "ReporterID");

            migrationBuilder.CreateIndex(
                name: "IX_DamageReports_VehicleID",
                table: "DamageReports",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseRequests_CompanyId",
                table: "LeaseRequests",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseRequests_EmployeeID",
                table: "LeaseRequests",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseRequests_RequestorCompanyID",
                table: "LeaseRequests",
                column: "RequestorCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseRequests_RequestorID",
                table: "LeaseRequests",
                column: "RequestorID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseRequests_VehicleID",
                table: "LeaseRequests",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionUpdates_SubscriptionSubcriptionID",
                table: "SubscriptionUpdates",
                column: "SubscriptionSubcriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionUpdates_UpdatedByEmployeeID",
                table: "SubscriptionUpdates",
                column: "UpdatedByEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployerID",
                table: "Users",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SubscriptionID",
                table: "Users",
                column: "SubscriptionID",
                unique: true,
                filter: "[SubscriptionID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DamageReports");

            migrationBuilder.DropTable(
                name: "LeaseRequests");

            migrationBuilder.DropTable(
                name: "SubscriptionUpdates");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}
