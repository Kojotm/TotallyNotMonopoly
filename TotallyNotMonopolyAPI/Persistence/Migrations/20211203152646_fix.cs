using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Chance", "", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, "8", "6,30,90,270,400,550", 3, 50, 100 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Col", "Row" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 1, "7", "6,30,90,270,400,550", 3, 50, 100 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Name", "Rent", "Type", "UpgradeCost", "Value" },
                values: new object[] { 8, "Chance", "", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TableCards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Col", "Row" },
                values: new object[] { 1, 2 });
        }
    }
}
