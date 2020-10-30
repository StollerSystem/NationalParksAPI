using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ParkArea",
                table: "Parks",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AnnualVisitors", "DateEstablished", "ParkArea", "ParkDescription", "ParkLocation", "ParkName" },
                values: new object[] { 1, 4020288, "March 1, 1872", 2219790.71, "test", "Wyoming, Montana, Idaha", "YellowStone" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AnnualVisitors", "DateEstablished", "ParkArea", "ParkDescription", "ParkLocation", "ParkName" },
                values: new object[] { 2, 1246053, "September 25, 1890", 404062.63, "test", "California", "Sequoia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "ParkArea",
                table: "Parks",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
