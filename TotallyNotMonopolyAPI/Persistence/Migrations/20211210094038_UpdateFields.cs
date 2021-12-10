using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The most famous ruin bar in the world.", "Szimpla Kert" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Instant Fogas is certainly the best party hub in not just the party district, but in whole Budapest", "Instant Fogas " });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "One of the best Jewish restaurants with an amazing looking ruin bar.", "Mazel Tov" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "It is the largest covered market in the city.", "Great Market Hall" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "It is a large park that offers relaxation and leisure areas for both tourists and residents of Budapest.", "Margaret island" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Citadel is the highest point in Budapest and from it you get the best views of the city.", "Citadel" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "It was initially erected in wood and cardboard for the 1896 exhibition, but was so successful that it was rebuilt using stone and brick.", "Hunedoara Castle" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "It is one of the most representative squares in Budapest and its statues represent the founders of the country.", "Heroes' Square" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "it is one of the most important neo-renaissance buildings in Hungary.", "Hungarian State Opera House" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { "It is one of the most beautiful thermal baths in Budapest, the capital city of Hungary.", "Gellert Spa" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Rudas Baths are considered one of the most beautiful Turkish baths in the world.", "Rudas Spa" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Széchenyi Spa is one of the biggest thermal centers in Europe.", "Széchenyi Spa" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Freedom Bridge in Budapest is considered the third with respect to the permanent bridges of the city and is the shortest of all.", "Liberty Bridge" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name" },
                values: new object[] { "It is the third newest bridge of Budapest, Hungary, connecting Buda and Pest across the River Danube.", "Erzsébet Bridge" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Chain Bridge is the oldest bridge in Budapest and the best known on the entire Danube. It is officially known as the Széchenyi Bridge in honor of its creator.", "Chain Bridge" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Budapest's most famous catholic church and is located in the heart of the Castle district.", "Matthias Church" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Its seven towers commemorate the seven founding tribes of Hungary. In charge of defending the city.", "Fisherman's bastion" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name" },
                values: new object[] { "It is also known as the Royal Palace, since it was formerly the residence of the kings of Hungary.", "Buda Castle" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Second most important place in Budapest, dedicated to the first king of Hungary, Saint Stephen.", "St. Stephen's Basilica" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The third largest parliament in the world and the most emblematic building in Budapest", "Parliament" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "8" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "9" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "10" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "12" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "14" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "15" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "17" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "19" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "20" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "22" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "24" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "25" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "27" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "28" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "30" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "32" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "33" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "35" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "38" });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".", "40" });
        }
    }
}
