using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreSqlDb.Migrations
{
    public partial class AddProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Todo");

            migrationBuilder.AddColumn<string>(
                name: "CitizenStatus",
                table: "Todo",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Todo",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactName",
                table: "Todo",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "EmergencyContactPhoneNumber",
                table: "Todo",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactRelationship",
                table: "Todo",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmploymentType",
                table: "Todo",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "Todo",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "PositionTitle",
                table: "Todo",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CitizenStatus",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "EmergencyContactName",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "EmergencyContactPhoneNumber",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "EmergencyContactRelationship",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "EmploymentType",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "PositionTitle",
                table: "Todo");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Todo",
                type: "TEXT",
                nullable: true);
        }
    }
}
