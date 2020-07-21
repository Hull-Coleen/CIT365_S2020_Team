using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class initalize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    PageNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Calling = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SacramentMeeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SacramentDate = table.Column<DateTime>(nullable: false),
                    ConductingBishopric = table.Column<string>(nullable: false),
                    OpeningPrayer = table.Column<string>(nullable: false),
                    OpeningHymnId = table.Column<int>(nullable: false),
                    SacramentHymnId = table.Column<int>(nullable: false),
                    IntermediateHymn = table.Column<string>(nullable: true),
                    ClosingHymnId = table.Column<int>(nullable: false),
                    ClosingPrayer = table.Column<string>(nullable: false),
                    Topic = table.Column<string>(nullable: false),
                    Speaker1 = table.Column<string>(nullable: true),
                    Speaker2 = table.Column<string>(nullable: true),
                    Speaker3 = table.Column<string>(nullable: true),
                    Speaker4 = table.Column<string>(nullable: true),
                    Speaker5 = table.Column<string>(nullable: true),
                    Speaker6 = table.Column<string>(nullable: true),
                    ClosingHymnNavigationID = table.Column<int>(nullable: true),
                    OpeningHymnNavigationID = table.Column<int>(nullable: true),
                    SacramentHymnNavigationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeeting", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_ClosingHymnNavigationID",
                        column: x => x.ClosingHymnNavigationID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_OpeningHymnNavigationID",
                        column: x => x.OpeningHymnNavigationID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_SacramentHymnNavigationID",
                        column: x => x.SacramentHymnNavigationID,
                        principalTable: "Hymn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "SacramentMeeting");

            migrationBuilder.DropTable(
                name: "Hymn");
        }
    }
}
