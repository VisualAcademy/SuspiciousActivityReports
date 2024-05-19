using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemoEngine.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuspiciousActivityReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportCorrectionIndicator = table.Column<bool>(type: "bit", nullable: false),
                    Subject_Multiple = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleInitial = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlsoKnownAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoingBusinessAs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZIPCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GovtIssuedID_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovtIssuedID_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovtIssuedID_IssuingState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleLicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleLicenseState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasinoAffiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessRelationshipStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuspiciousActivityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuspiciousActivityStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuspiciousActivityEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuspiciousActivityAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LawEnforcementContacted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportingCasinoTradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportingCasinoLegalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasinoAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasinoCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasinoState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasinoZIPCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GamingInstitutionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasinoEIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMiddleInitial = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactWorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportPreparedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NarrativeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuspiciousActivityReports", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuspiciousActivityReports");
        }
    }
}
