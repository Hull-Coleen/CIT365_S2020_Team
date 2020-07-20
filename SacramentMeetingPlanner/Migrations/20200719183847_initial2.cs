using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_SacramentMeeting_SacramentMeetingID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_SacramentMeetingID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "SacramentMeetingID",
                table: "Member");

            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "SacramentMeeting",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false),
                    MeetingID = table.Column<int>(nullable: false),
                    SacramentMeetingID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => new { x.MeetingID, x.MemberID });
                    table.ForeignKey(
                        name: "FK_Speaker_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speaker_SacramentMeeting_SacramentMeetingID",
                        column: x => x.SacramentMeetingID,
                        principalTable: "SacramentMeeting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MemberID",
                table: "Speaker",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_SacramentMeetingID",
                table: "Speaker",
                column: "SacramentMeetingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "SacramentMeeting",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "SacramentMeetingID",
                table: "Member",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_SacramentMeetingID",
                table: "Member",
                column: "SacramentMeetingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_SacramentMeeting_SacramentMeetingID",
                table: "Member",
                column: "SacramentMeetingID",
                principalTable: "SacramentMeeting",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
