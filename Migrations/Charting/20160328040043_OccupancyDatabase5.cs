using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace ChartingProject.Migrations.Charting
{
    public partial class OccupancyDatabase5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Percent", table: "Percent");
            migrationBuilder.DropColumn(name: "Id", table: "Percent");
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Percent", table: "Percent");
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
    }
}
