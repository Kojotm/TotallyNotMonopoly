using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddFirstCardSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TableCards",
                columns: new[] { "Id", "Col", "Color", "Description", "Image", "Level", "Name", "Rent", "Row", "SetNumber", "Type", "UpgradeCost", "Value" },
                values: new object[,]
                {
                    { 1, 2, 8, "This is the start point.", "url('../../assets/start-tile.png')", 0, "Go", "", 2, 1, 5, 0, 200 },
                    { 23, 2, 4, ".", "", 0, "", "18,90,250,700,875,1050", 1, 1, 3, 150, 220 },
                    { 24, 2, 8, ".", "", 0, "Chance", "", 1, 1, 0, 0, 0 },
                    { 25, 2, 4, ".", "", 0, "", "18,90,250,700,875,1050", 1, 1, 3, 150, 220 },
                    { 26, 2, 4, ".", "", 0, "", "20,100,300,750,925,1100", 1, 1, 3, 150, 240 },
                    { 27, 2, 8, ".", "", 0, "Tram 2", "25,50,100,200", 1, 1, 2, 0, 200 },
                    { 28, 2, 5, ".", "", 0, "", "22,110,330,800,975,1150", 1, 1, 3, 150, 260 },
                    { 29, 2, 5, ".", "", 0, "", "22,110,330,800,975,1150", 1, 1, 3, 150, 260 },
                    { 30, 1, 8, ".", "", 0, "Water works", "4,10", 2, 1, 6, 0, 150 },
                    { 31, 2, 5, ".", "", 0, "", "24,120,360,850,1025,1200", 1, 1, 3, 150, 280 },
                    { 32, 2, 8, "It's NOT your lucky day, you have to resit your last exam.", "url('../../assets/go-to-jail-tile.png')", 0, "Go to your re-examination", "", 2, 1, 5, 0, 0 },
                    { 33, 1, 6, ".", "", 0, "", "26,130,390,900,1100,1275", 2, 1, 3, 200, 300 },
                    { 34, 1, 6, ".", "", 0, "", "26,130,390,900,1100,1275", 2, 1, 3, 200, 300 },
                    { 35, 1, 8, "Community Chest.", "", 0, "Community Chest", "", 2, 1, 1, 0, 0 },
                    { 36, 1, 6, ".", "", 0, "", "28,150,450,1000,1200,1400", 2, 1, 3, 200, 320 },
                    { 37, 1, 8, ".", "", 0, "Tram 19", "25,50,100,200", 2, 1, 2, 0, 200 },
                    { 38, 1, 8, ".", "", 0, "Chance", "", 2, 1, 0, 0, 0 },
                    { 39, 1, 7, ".", "", 0, "", "35,175,500,1100,1300,1500", 2, 1, 3, 200, 350 },
                    { 22, 2, 8, "It's your lucky day, you don't have to take the exam.", "url('../../assets/parking-tile.png')", 0, "Offered exam grade", "", 2, 1, 5, 0, 0 },
                    { 40, 1, 8, "You were drunk during your exam. Pay your resit cost.", "", 0, "Super Tax", "200", 2, 1, 4, 0, 0 },
                    { 21, 1, 3, ".", "", 0, "", "16,80,220,600,800,1000", 2, 1, 3, 100, 200 },
                    { 19, 1, 8, "Community Chest.", "", 0, "Community Chest", "", 2, 1, 1, 0, 0 },
                    { 2, 2, 0, "A famous bar amoung students not far from the university campus.", "", 0, "Szertár", "2,10,30,90,160,250", 1, 1, 3, 50, 60 },
                    { 3, 2, 8, "Community Chest.", "", 0, "Community Chest", "", 1, 1, 1, 0, 0 },
                    { 4, 2, 0, "A jug of Arany Ászok is only 330 HUF.", "", 0, "Bak Egér Borozó", "4,20,60,180,320,450", 1, 1, 3, 50, 60 },
                    { 5, 2, 8, "You were hangover during your exam. Pay your resit cost.", "", 0, "Income Tax", "100", 1, 1, 4, 0, 0 },
                    { 6, 2, 8, "You were hangover during your exam. Pay your resit cost.", "", 0, "Income Tax", "4,20,60,180,320,450", 1, 1, 4, 100, 60 },
                    { 7, 2, 8, ".", "", 0, "Tram 4-6", "25,50,100,200", 1, 1, 2, 0, 200 },
                    { 8, 2, 1, ".", "", 0, "", "6,30,90,270,400,550", 1, 1, 3, 50, 100 },
                    { 9, 2, 8, ".", "", 0, "Chance", "", 1, 1, 0, 0, 0 },
                    { 10, 2, 1, ".", "", 0, "", "6,30,90,270,400,550", 1, 1, 3, 50, 100 },
                    { 11, 2, 1, ".", "", 0, "", "8,40,100,300,450,600", 1, 1, 3, 50, 120 },
                    { 12, 2, 8, "This is the jail.", "url('../../assets/jail-tile.png')", 0, "Jail", "", 2, 1, 5, 0, 50 },
                    { 13, 1, 2, ".", "", 0, "", "10,50,150,450,625,750", 2, 1, 3, 100, 140 },
                    { 14, 1, 8, ".", "", 0, "Electric Company", "4,10", 2, 1, 6, 0, 150 },
                    { 15, 1, 2, ".", "", 0, "", "10,50,150,450,625,750", 2, 1, 3, 100, 140 },
                    { 16, 1, 2, ".", "", 0, "", "12,60,180,500,700,900", 2, 1, 3, 100, 160 },
                    { 17, 1, 8, ".", "", 0, "Tram 1", "25,50,100,200", 2, 1, 2, 0, 200 },
                    { 18, 1, 3, ".", "", 0, "", "14,70,200,550,700,900", 2, 1, 3, 100, 180 },
                    { 20, 1, 3, ".", "", 0, "", "14,70,200,550,700,900", 2, 1, 3, 100, 180 },
                    { 41, 1, 7, ".", "", 0, "", "50,200,600,1400,1700,2000", 2, 1, 3, 200, 400 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 41);
        }
    }
}
