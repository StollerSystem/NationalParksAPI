using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class StateParkYearRound : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEstablished",
                table: "StateParks");

            migrationBuilder.AddColumn<bool>(
                name: "YearRound",
                table: "StateParks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 3,
                column: "YearRound",
                value: true);

            migrationBuilder.UpdateData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 4,
                column: "YearRound",
                value: true);

            migrationBuilder.UpdateData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 5,
                column: "YearRound",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearRound",
                table: "StateParks");

            migrationBuilder.AddColumn<string>(
                name: "DateEstablished",
                table: "StateParks",
                nullable: true);
        }
    }
}
