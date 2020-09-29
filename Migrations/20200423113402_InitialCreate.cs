using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    FullAddress = table.Column<string>(nullable: false),
                    MailingAddress = table.Column<string>(nullable: true),
                    AsAboveAddress = table.Column<bool>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<long>(nullable: false),
                    CitizenStatus = table.Column<string>(nullable: false),
                    EmploymentStartDate = table.Column<DateTime>(nullable: false),
                    EmploymentType = table.Column<string>(nullable: true),
                    PositionTitle = table.Column<string>(nullable: true),
                    EmergencyContactName = table.Column<string>(nullable: false),
                    EmergencyContactRelationship = table.Column<string>(nullable: false),
                    EmergencyContactPhoneNumber = table.Column<long>(nullable: false),
                    EmployeeSignature = table.Column<byte[]>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
