using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ChartingProject.Migrations.Charting
{
    public partial class OccupancyDatabase6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Week", table: "Week");
            migrationBuilder.DropColumn(name: "Id", table: "Week");
            migrationBuilder.AddColumn<int>(
                name: "weekId",
                table: "Week",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Week",
                table: "Week",
                column: "weekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Week", table: "Week");
            migrationBuilder.DropColumn(name: "weekId", table: "Week");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Week",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Week",
                table: "Week",
                column: "Id");
        }
    }
}
