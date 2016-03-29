using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ChartingProject.Migrations.Charting
{
    public partial class ChartingDatabaseChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Occupancy", table: "Occupancy");
            migrationBuilder.DropColumn(name: "PrimaryTrackingKey", table: "Occupancy");
            migrationBuilder.AddColumn<long>(
                name: "OccupanyKey",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupancy",
                table: "Occupancy",
                column: "OccupanyKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Occupancy", table: "Occupancy");
            migrationBuilder.DropColumn(name: "OccupanyKey", table: "Occupancy");
            migrationBuilder.AddColumn<long>(
                name: "PrimaryTrackingKey",
                table: "Occupancy",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupancy",
                table: "Occupancy",
                column: "PrimaryTrackingKey");
        }
    }
}
