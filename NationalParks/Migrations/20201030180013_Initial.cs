using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalPark",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NationalParkName = table.Column<string>(nullable: false),
                    NationalParkDescription = table.Column<string>(nullable: false),
                    NationalParkLocation = table.Column<string>(nullable: false),
                    DateEstablished = table.Column<string>(nullable: false),
                    NationalParkArea = table.Column<double>(nullable: false),
                    AnnualVisitors = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalPark", x => x.NationalParkId);
                });

            migrationBuilder.CreateTable(
                name: "StatePark",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateParkName = table.Column<string>(nullable: false),
                    StateParkDescription = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    DateEstablished = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatePark", x => x.StateParkId);
                });

            migrationBuilder.InsertData(
                table: "NationalPark",
                columns: new[] { "NationalParkId", "AnnualVisitors", "DateEstablished", "NationalParkArea", "NationalParkDescription", "NationalParkLocation", "NationalParkName" },
                values: new object[,]
                {
                    { 1, 4020288, "March 1, 1872", 2219790.71, "test", "Wyoming, Montana, Idaha", "YellowStone" },
                    { 2, 1246053, "September 25, 1890", 404062.63, "test", "California", "Sequoia" }
                });

            migrationBuilder.InsertData(
                table: "StatePark",
                columns: new[] { "StateParkId", "DateEstablished", "State", "StateParkDescription", "StateParkName" },
                values: new object[,]
                {
                    { 1, null, "Oregon", "test", "Goose Lake" },
                    { 2, null, "Oregon", "test", "Smith Rock" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalPark");

            migrationBuilder.DropTable(
                name: "StatePark");
        }
    }
}
