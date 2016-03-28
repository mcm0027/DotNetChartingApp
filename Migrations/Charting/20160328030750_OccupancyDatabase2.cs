using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ChartingProject.Migrations.Charting
{
    public partial class OccupancyDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Weeks", table: "Occupancy");
            migrationBuilder.DropColumn(name: "percents", table: "Occupancy");
            migrationBuilder.CreateTable(
                name: "Percent",
                columns: table => new
                {
                    Percent1 = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OccupancyMonth = table.Column<string>(nullable: true),
                    Percent2 = table.Column<int>(nullable: false),
                    Percent3 = table.Column<int>(nullable: false),
                    Percent4 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Percent", x => x.Percent1);
                    table.ForeignKey(
                        name: "FK_Percent_Occupancy_OccupancyMonth",
                        column: x => x.OccupancyMonth,
                        principalTable: "Occupancy",
                        principalColumn: "Month",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Week",
                columns: table => new
                {
                    Week1 = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OccupancyMonth = table.Column<string>(nullable: true),
                    Week2 = table.Column<int>(nullable: false),
                    Week3 = table.Column<int>(nullable: false),
                    Week4 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Week", x => x.Week1);
                    table.ForeignKey(
                        name: "FK_Week_Occupancy_OccupancyMonth",
                        column: x => x.OccupancyMonth,
                        principalTable: "Occupancy",
                        principalColumn: "Month",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Percent");
            migrationBuilder.DropTable("Week");
            migrationBuilder.AddColumn<int>(
                name: "Weeks",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "percents",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0);
        }
    }
}
