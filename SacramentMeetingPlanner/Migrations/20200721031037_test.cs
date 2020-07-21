using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SacramentMeeting_Hymn_ClosingHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropForeignKey(
                name: "FK_SacramentMeeting_Hymn_OpeningHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropForeignKey(
                name: "FK_SacramentMeeting_Hymn_SacramentHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropIndex(
                name: "IX_SacramentMeeting_ClosingHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropIndex(
                name: "IX_SacramentMeeting_OpeningHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropIndex(
                name: "IX_SacramentMeeting_SacramentHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "ClosingHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "OpeningHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "SacramentHymnNavigationID",
                table: "SacramentMeeting");

            migrationBuilder.AlterColumn<string>(
                name: "SacramentHymnId",
                table: "SacramentMeeting",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "OpeningHymnId",
                table: "SacramentMeeting",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ClosingHymnId",
                table: "SacramentMeeting",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SacramentHymnId",
                table: "SacramentMeeting",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "OpeningHymnId",
                table: "SacramentMeeting",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ClosingHymnId",
                table: "SacramentMeeting",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ClosingHymnNavigationID",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpeningHymnNavigationID",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SacramentHymnNavigationID",
                table: "SacramentMeeting",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_ClosingHymnNavigationID",
                table: "SacramentMeeting",
                column: "ClosingHymnNavigationID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_OpeningHymnNavigationID",
                table: "SacramentMeeting",
                column: "OpeningHymnNavigationID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_SacramentHymnNavigationID",
                table: "SacramentMeeting",
                column: "SacramentHymnNavigationID");

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentMeeting_Hymn_ClosingHymnNavigationID",
                table: "SacramentMeeting",
                column: "ClosingHymnNavigationID",
                principalTable: "Hymn",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentMeeting_Hymn_OpeningHymnNavigationID",
                table: "SacramentMeeting",
                column: "OpeningHymnNavigationID",
                principalTable: "Hymn",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentMeeting_Hymn_SacramentHymnNavigationID",
                table: "SacramentMeeting",
                column: "SacramentHymnNavigationID",
                principalTable: "Hymn",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
