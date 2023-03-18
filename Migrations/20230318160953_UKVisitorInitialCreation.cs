using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProAgricaTest.Migrations
{
    /// <inheritdoc />
    public partial class UKVisitorInitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UKVisitors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorCategory = table.Column<int>(type: "int", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PassportValidTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryOfNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryApproved = table.Column<bool>(type: "bit", nullable: true),
                    NoOfUKEntries = table.Column<int>(type: "int", nullable: true),
                    VisaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisaValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BiometricNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UKVisitors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UKVisitors");
        }
    }
}
