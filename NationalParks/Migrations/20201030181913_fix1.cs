using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class fix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StatePark",
                table: "StatePark");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalPark",
                table: "NationalPark");

            migrationBuilder.RenameTable(
                name: "StatePark",
                newName: "StateParks");

            migrationBuilder.RenameTable(
                name: "NationalPark",
                newName: "NationalParks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateParks",
                table: "StateParks",
                column: "StateParkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalParks",
                table: "NationalParks",
                column: "NationalParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StateParks",
                table: "StateParks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalParks",
                table: "NationalParks");

            migrationBuilder.RenameTable(
                name: "StateParks",
                newName: "StatePark");

            migrationBuilder.RenameTable(
                name: "NationalParks",
                newName: "NationalPark");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatePark",
                table: "StatePark",
                column: "StateParkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalPark",
                table: "NationalPark",
                column: "NationalParkId");
        }
    }
}
