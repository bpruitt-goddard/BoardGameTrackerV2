using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardGameTrackerV2.Data.Migrations
{
    public partial class SeedPlayerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name" },
                values: new object[] { -1, "Unknown" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
