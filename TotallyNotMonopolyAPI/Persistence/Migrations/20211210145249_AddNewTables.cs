using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChanceCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChanceCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FortuneCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FortuneCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ChanceCards",
                columns: new[] { "Id", "Amount", "Description", "Type" },
                values: new object[,]
                {
                    { 1, "Parliament, 0", "Advance to Parliament", "advance" },
                    { 16, "150", "Your building loan matures � collect $150 ", "earn" },
                    { 15, "50", "You have been elected chairman of the board � pay each player $50 ", "spend-each-player" },
                    { 14, "Tram 4-6, 0", "Take a trip to Tram 4-6 � if you pass Go collect $200", "advance" },
                    { 13, "15", "Speeding fine $15", "spend" },
                    { 11, "0", "Go directly to Jail � do not pass Go, do not collect $200 ", "jail" },
                    { 10, "3", "Go back 3 spaces", "back" },
                    { 9, "", "Get Out of Jail Free", "jail-card" },
                    { 12, "25", "Make general repairs on all your property � for each level pay $25", "repairs" },
                    { 7, "Utility, 0", "Advance token to nearest Utility. If unowned, you may buy it from the Bank.", "advance" },
                    { 6, "Tram, 0", "Advance to the nearest Tram. If unowned, you may buy it from the Bank.", "advance" },
                    { 5, "Tram, 0", "Advance to the nearest Tram. If unowned, you may buy it from the Bank.", "advance" },
                    { 4, "Great Market Hall, 0", "Advance to Great Market Hall. If you pass Go, collect $200", "advance" },
                    { 3, "Sz�chenyi Spa, 0", "Advance to Sz�chenyi Spa. If you pass Go, collect $200", "advance" },
                    { 2, "Go, 0", "Advance to Go (Collect $200)", "advance" },
                    { 8, "50", "Bank pays you dividend of $50", "earn" }
                });

            migrationBuilder.InsertData(
                table: "FortuneCards",
                columns: new[] { "Id", "Amount", "Description", "Type" },
                values: new object[,]
                {
                    { 10, "25", "Receive $25 Consultancy Fee ", "earn" },
                    { 15, "50", "From sale of stock you get $50 ", "earn" },
                    { 14, "100", "You inherit $100 ", "earn" },
                    { 13, "10", "You have won second prize in a beauty contest� collect $10 ", "earn" },
                    { 12, "40", "You are assessed for street repairs � $40 per level", "repairs" },
                    { 11, "50", "Pay School Fees of $50 ", "spend" },
                    { 9, "100", "Pay Hospital Fees of $100 ", "spend" },
                    { 1, "0", "Advance to Go (Collect $200) ", "advance" },
                    { 7, "100", "Life Insurance Matures � collect $100 ", "earn" },
                    { 6, "10", "It is your birthday Collect $10 from each player ", "earn-each-player" },
                    { 5, "0", "Go to jail � go directly to jail � Do not pass Go, do not collect $200", "jail" },
                    { 4, "0", "Get Out of Jail Free", "jail-card" },
                    { 3, "50", "Doctor's fees � Pay $50", "spend" },
                    { 2, "200", "Bank error in your favor. Collect $200", "earn" },
                    { 16, "100", "Holiday Fund matures - Receive $100 ", "earn" },
                    { 8, "20", "Income Tax refund � collect $20", "earn" },
                    { 17, "50", "Pay school fees of $50", "spend" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChanceCards");

            migrationBuilder.DropTable(
                name: "FortuneCards");
        }
    }
}
