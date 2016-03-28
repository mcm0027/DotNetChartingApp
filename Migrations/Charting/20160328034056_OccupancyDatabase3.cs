using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ChartingProject.Migrations.Charting
{
    public partial class OccupancyDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Week4",
                table: "Week",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Week3",
                table: "Week",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Week2",
                table: "Week",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Week1",
                table: "Week",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Week4",
                table: "Week",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Week3",
                table: "Week",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Week2",
                table: "Week",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Week1",
                table: "Week",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
