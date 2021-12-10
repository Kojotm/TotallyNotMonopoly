using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: "Parliament");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: "Go");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Szechenyi Spa", "Advance to Szechenyi Spa, if you pass Go, collect $200" });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Great Market Hall", "Advance to Great Market Hall, if you pass Go, collect $200" });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Tram", "Advance to the nearest Tram, if unowned, you may buy it from the Bank." });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Tram", "Advance to the nearest Tram, if unowned, you may buy it from the Bank." });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Utility", "Advance token to nearest Utility, if unowned, you may buy it from the Bank." });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Go directly to Jail, do not pass Go, do not collect $200 ");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Make general repairs on all your property, for each level pay $25");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Tram 4-6", "Take a trip to Tram 4-6, if you pass Go collect $200" });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "You have been elected chairman of the board, pay each player $50 ");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Your building loan matures, collect $150 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Advance to Go (Collect $200)");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Bank error in your favor, collect $200");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Doctor's fees, pay $50");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Go directly to jail");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "It is your birthday Collect $10 from each player");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Life Insurance Matures, collect $100");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Income Tax refund, collect $20");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Pay Hospital Fees of $100");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Receive $25 Consultancy Fee");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Pay School Fees of $50");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "You are assessed for street repairs, $40 per level");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "You have won second prize in a beauty contest, collect $10");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "You inherit $100");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "From sale of stock you get $50");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Holiday Fund matures, receive $100");

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Szechenyi Spa is one of the biggest thermal centers in Europe.", "Szechenyi Spa" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "The Chain Bridge is the oldest bridge in Budapest and the best known on the entire Danube. It is officially known as the Szechenyi Bridge in honor of its creator.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: "Parliament, 0");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: "Go, 0");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Szechenyi Spa, 0", "Advance to Szechenyi Spa. If you pass Go, collect $200" });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Great Market Hall, 0", "Advance to Great Market Hall. If you pass Go, collect $200" });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Tram, 0", "Advance to the nearest Tram. If unowned, you may buy it from the Bank." });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Tram, 0", "Advance to the nearest Tram. If unowned, you may buy it from the Bank." });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Utility, 0", "Advance token to nearest Utility. If unowned, you may buy it from the Bank." });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Go directly to Jail , do not pass Go, do not collect $200 ");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Make general repairs on all your property , for each level pay $25");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "Description" },
                values: new object[] { "Tram 4-6, 0", "Take a trip to Tram 4-6 , if you pass Go collect $200" });

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "You have been elected chairman of the board , pay each player $50 ");

            migrationBuilder.UpdateData(
                table: "ChanceCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Your building loan matures , collect $150 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Advance to Go (Collect $200) ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Bank error in your favor. Collect $200");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Doctor's fees , Pay $50");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Go to jail , go directly to jail , Do not pass Go, do not collect $200");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "It is your birthday Collect $10 from each player ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Life Insurance Matures , collect $100 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Income Tax refund , collect $20");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Pay Hospital Fees of $100 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Receive $25 Consultancy Fee ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Pay School Fees of $50 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "You are assessed for street repairs , $40 per level");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "You have won second prize in a beauty contest, collect $10 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "You inherit $100 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "From sale of stock you get $50 ");

            migrationBuilder.UpdateData(
                table: "FortuneCards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Holiday Fund matures - Receive $100 ");

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Széchenyi Spa is one of the biggest thermal centers in Europe.", "Széchenyi Spa" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "The Chain Bridge is the oldest bridge in Budapest and the best known on the entire Danube. It is officially known as the Széchenyi Bridge in honor of its creator.");
        }
    }
}
