using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ChartingProject.Migrations.Charting
{
    public partial class OccupancyDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Occupancy",
                columns: table => new
                {
                    Month = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Weeks = table.Column<int>(nullable: false),
                    percents = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupancy", x => x.Month);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Occupancy");
        }
    }
}
