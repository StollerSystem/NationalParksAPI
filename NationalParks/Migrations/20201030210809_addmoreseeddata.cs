using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class addmoreseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "AnnualVisitors", "DateEstablished", "NationalParkArea", "NationalParkDescription", "NationalParkLocation", "NationalParkName" },
                values: new object[,]
                {
                    { 3, 4422861, "October 1, 1890", 761747.5, "test", "California", "Yosemite" },
                    { 4, 1501621, "March 2, 1899", 236381.64000000001, "test", "Washington", "Mount Rainier" },
                    { 5, 704512, "May 22, 1902", 236381.64000000001, "test", "Oregon Lake", "Crater Lake" }
                });

            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "DateEstablished", "State", "StateParkDescription", "StateParkName" },
                values: new object[,]
                {
                    { 3, null, "Oregon", "test", "The Cove Palisades" },
                    { 4, null, "Oregon", "test", "Cape Lookout" },
                    { 5, null, "Oregon", "test", "Oswald West" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 5);
        }
    }
}
