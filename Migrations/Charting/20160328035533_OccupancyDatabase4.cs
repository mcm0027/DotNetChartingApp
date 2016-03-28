using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ChartingProject.Migrations.Charting
{
    public partial class OccupancyDatabase4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Week", table: "Week");
            migrationBuilder.DropPrimaryKey(name: "PK_Percent", table: "Percent");
            migrationBuilder.AlterColumn<string>(
                name: "Week1",
                table: "Week",
                nullable: true);
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
            migrationBuilder.AlterColumn<int>(
                name: "Percent1",
                table: "Percent",
                nullable: false);
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Percent",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Percent",
                table: "Percent",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Week", table: "Week");
            migrationBuilder.DropPrimaryKey(name: "PK_Percent", table: "Percent");
            migrationBuilder.DropColumn(name: "Id", table: "Week");
            migrationBuilder.DropColumn(name: "Id", table: "Percent");
            migrationBuilder.AlterColumn<string>(
                name: "Week1",
                table: "Week",
                nullable: false);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Week",
                table: "Week",
                column: "Week1");
            migrationBuilder.AlterColumn<int>(
                name: "Percent1",
                table: "Percent",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Percent",
                table: "Percent",
                column: "Percent1");
        }
    }
}
