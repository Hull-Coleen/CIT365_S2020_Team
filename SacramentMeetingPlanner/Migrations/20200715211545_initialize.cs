using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class initialize : Migration
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
                name: "SacramentMeeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SacramentDate = table.Column<DateTime>(nullable: false),
                    ConductingBishopric = table.Column<string>(nullable: false),
                    OpeningPrayer = table.Column<string>(nullable: false),
                    OpeningHymn = table.Column<string>(nullable: false),
                    SacramentHymn = table.Column<string>(nullable: false),
                    IntermediateHymn = table.Column<int>(nullable: true),
                    ClosingHymn = table.Column<string>(nullable: false),
                    ClosingPrayer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeeting", x => x.ID);
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
                    PhoneNumber = table.Column<string>(nullable: false),
                    SacramentMeetingID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Member_SacramentMeeting_SacramentMeetingID",
                        column: x => x.SacramentMeetingID,
                        principalTable: "SacramentMeeting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_SacramentMeetingID",
                table: "Member",
                column: "SacramentMeetingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "SacramentMeeting");
        }
    }
}
