using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBilet.DataAccess.Migrations
{
    public partial class migbus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seat",
                table: "Buses");

            migrationBuilder.AddColumn<int>(
                name: "SeatCapacity",
                table: "Buses",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatCapacity",
                table: "Buses");

            migrationBuilder.AddColumn<int>(
                name: "Seat",
                table: "Buses",
                type: "int",
                maxLength: 40,
                nullable: false,
                defaultValue: 0);
        }
    }
}
