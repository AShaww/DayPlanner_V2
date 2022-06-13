using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayPlanner_V2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableLayout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TopPriorities1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopPriorities2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopPriorities3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrainDump = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiveAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FiveAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SixAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SixAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SevenAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SevenAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EightAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EightAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NineAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NineAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElevenAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElevenAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwelveAM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwelveAM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnePM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnePM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoPM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoPM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThreePM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThreePM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FourPM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FourPM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FivePM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FivePM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SixPM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SixPM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SevenPM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SevenPM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EightPM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EightPM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NinePM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NinePM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenPM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenPM30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElevenPM00 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElevenPM30 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableLayout", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableLayout");
        }
    }
}
