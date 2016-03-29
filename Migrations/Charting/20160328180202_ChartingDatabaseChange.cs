using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ChartingProject.Migrations.Charting
{
    public partial class ChartingDatabaseChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Occupancy", table: "Occupancy");
            migrationBuilder.DropColumn(name: "Id", table: "Occupancy");
            migrationBuilder.DropTable("Percent");
            migrationBuilder.DropTable("Week");
            migrationBuilder.AlterColumn<int>(
                name: "Month",
                table: "Occupancy",
                nullable: false);
            migrationBuilder.AddColumn<long>(
                name: "PrimaryTrackingKey",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Occupancy",
                nullable: true);
            migrationBuilder.AddColumn<float>(
                name: "Percent",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupancy",
                table: "Occupancy",
                column: "PrimaryTrackingKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Occupancy", table: "Occupancy");
            migrationBuilder.DropColumn(name: "PrimaryTrackingKey", table: "Occupancy");
            migrationBuilder.DropColumn(name: "Label", table: "Occupancy");
            migrationBuilder.DropColumn(name: "Percent", table: "Occupancy");
            migrationBuilder.DropColumn(name: "Year", table: "Occupancy");
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
                    weekId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OccupancyMonth = table.Column<string>(nullable: true),
                    Week1 = table.Column<string>(nullable: true),
                    Week2 = table.Column<string>(nullable: true),
                    Week3 = table.Column<string>(nullable: true),
                    Week4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Week", x => x.weekId);
                    table.ForeignKey(
                        name: "FK_Week_Occupancy_OccupancyMonth",
                        column: x => x.OccupancyMonth,
                        principalTable: "Occupancy",
                        principalColumn: "Month",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Occupancy",
                nullable: false);
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupancy",
                table: "Occupancy",
                column: "Month");
        }
    }
}
