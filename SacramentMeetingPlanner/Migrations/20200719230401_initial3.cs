using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Speaker1",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker2",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker3",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker4",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker5",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Speaker6",
                table: "SacramentMeeting",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speaker1",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "Speaker2",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "Speaker3",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "Speaker4",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "Speaker5",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "Speaker6",
                table: "SacramentMeeting");
        }
    }
}
