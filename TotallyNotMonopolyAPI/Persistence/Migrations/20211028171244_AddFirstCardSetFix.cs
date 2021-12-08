using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddFirstCardSetFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { ".", "Tram 4-6", "25,50,100,200", 2, 0, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, "", "6,30,90,270,400,550", 3, 50, 100 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Chance", "", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, "", "6,30,90,270,400,550", 3, 50, 100 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "8,40,100,300,450,600", 120 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Description", "Image", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "This is the jail.", "url('../../assets/jail-tile.png')", "Jail", "", 2, 5, 0, 50 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Col", "Color", "Description", "Image", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, 2, ".", "", "", "10,50,150,450,625,750", 3, 100, 140 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Electric Company", "4,10", 6, 0, 150 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, "", "10,50,150,450,625,750", 3, 100, 140 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "12,60,180,500,700,900", 160 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Tram 1", "25,50,100,200", 2, 0, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 3, "", "14,70,200,550,700,900", 3, 100, 180 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Community Chest.", "Community Chest", "", 1, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 3, ".", "", "14,70,200,550,700,900", 3, 100, 180 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "16,80,220,600,800,1000", 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Col", "Color", "Description", "Image", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, 8, "It's your lucky day, you don't have to take the exam.", "url('../../assets/parking-tile.png')", "Offered exam grade", "", 5, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Color", "Description", "Image", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 4, ".", "", "", "18,90,250,700,875,1050", 1, 3, 150, 220 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Chance", "", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 4, "", "18,90,250,700,875,1050", 3, 150, 220 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "20,100,300,750,925,1100", 240 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Tram 2", "25,50,100,200", 2, 0, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 5, "", "22,110,330,800,975,1150", 3, 150, 260 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Col", "Color", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, 8, "Water works", "4,10", 2, 6, 0, 150 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Col", "Color", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, 5, "", "24,120,360,850,1025,1200", 1, 3, 150, 280 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Color", "Description", "Image", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "It's NOT your lucky day, you have to resit your last exam.", "url('../../assets/go-to-jail-tile.png')", "Go to your re-examination", "", 2, 5, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Col", "Color", "Description", "Image", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, 6, ".", "", "", "26,130,390,900,1100,1275", 3, 200, 300 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Community Chest.", "Community Chest", "", 1, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 6, ".", "", "28,150,450,1000,1200,1400", 3, 200, 320 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Tram 19", "25,50,100,200", 2, 0, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Rent", "Type", "Value" },
                values: new object[] { "Chance", "", 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 7, "", "35,175,500,1100,1300,1500", 3, 200, 350 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "You were drunk during your exam. Pay your resit cost.", "Super Tax", "200", 4, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 7, ".", "", "50,200,600,1400,1700,2000", 3, 200, 400 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { "You were hangover during your exam. Pay your resit cost.", "Income Tax", "4,20,60,180,320,450", 4, 100, 60 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Tram 4-6", "25,50,100,200", 2, 0, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, "", "6,30,90,270,400,550", 3, 50, 100 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Chance", "", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "6,30,90,270,400,550", 100 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Description", "Image", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, ".", "", "", "8,40,100,300,450,600", 1, 3, 50, 120 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Col", "Color", "Description", "Image", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, 8, "This is the jail.", "url('../../assets/jail-tile.png')", "Jail", "", 5, 0, 50 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, "", "10,50,150,450,625,750", 3, 100, 140 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Electric Company", "4,10", 6, 0, 150 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "10,50,150,450,625,750", 140 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, "", "12,60,180,500,700,900", 3, 100, 160 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Tram 1", "25,50,100,200", 2, 0, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 3, ".", "", "14,70,200,550,700,900", 3, 100, 180 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Community Chest.", "Community Chest", "", 1, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "14,70,200,550,700,900", 180 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Col", "Color", "Description", "Image", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, 3, ".", "", "", "16,80,220,600,800,1000", 3, 100, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Color", "Description", "Image", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "It's your lucky day, you don't have to take the exam.", "url('../../assets/parking-tile.png')", "Offered exam grade", "", 2, 5, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 4, "", "18,90,250,700,875,1050", 3, 150, 220 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Chance", "", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rent", "Value" },
                values: new object[] { "18,90,250,700,875,1050", 220 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 4, "", "20,100,300,750,925,1100", 3, 150, 240 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Tram 2", "25,50,100,200", 2, 0, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Col", "Color", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, 5, "", "22,110,330,800,975,1150", 1, 3, 150, 260 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Col", "Color", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, 8, "Water works", "4,10", 2, 6, 0, 150 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Color", "Description", "Image", "Name", "Rent", "Row", "Type", "UpgradeCost", "Value" },
                values: new object[] { 5, ".", "", "", "24,120,360,850,1025,1200", 1, 3, 150, 280 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Col", "Color", "Description", "Image", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 2, 8, "It's NOT your lucky day, you have to resit your last exam.", "url('../../assets/go-to-jail-tile.png')", "Go to your re-examination", "", 5, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 6, ".", "", "26,130,390,900,1100,1275", 3, 200, 300 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Community Chest.", "Community Chest", "", 1, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 6, "", "28,150,450,1000,1200,1400", 3, 200, 320 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Rent", "Type", "Value" },
                values: new object[] { "Tram 19", "25,50,100,200", 2, 200 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Chance", "", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 7, ".", "", "35,175,500,1100,1300,1500", 3, 200, 350 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Color", "Description", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "You were drunk during your exam. Pay your resit cost.", "Super Tax", "200", 4, 0, 0 });

            migrationBuilder.InsertData(
                table: "TableCards",
                columns: new[] { "Id", "Col", "Color", "Description", "Image", "Level", "Name", "Rent", "Row", "SetNumber", "Type", "UpgradeCost", "Value" },
                values: new object[] { 41, 1, 7, ".", "", 0, "", "50,200,600,1400,1700,2000", 2, 1, 3, 200, 400 });
        }
    }
}
