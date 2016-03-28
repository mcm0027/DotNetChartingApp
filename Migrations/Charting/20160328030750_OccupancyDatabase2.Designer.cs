using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ChartingProject.Models;

namespace ChartingProject.Migrations.Charting
{
    [DbContext(typeof(ChartingContext))]
    [Migration("20160328030750_OccupancyDatabase2")]
    partial class OccupancyDatabase2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChartingProject.Models.Occupancy", b =>
                {
                    b.Property<string>("Month");

                    b.Property<int>("Id");

                    b.HasKey("Month");
                });

            modelBuilder.Entity("ChartingProject.Models.Percent", b =>
                {
                    b.Property<int>("Percent1")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OccupancyMonth");

                    b.Property<int>("Percent2");

                    b.Property<int>("Percent3");

                    b.Property<int>("Percent4");

                    b.HasKey("Percent1");
                });

            modelBuilder.Entity("ChartingProject.Models.Week", b =>
                {
                    b.Property<int>("Week1")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OccupancyMonth");

                    b.Property<int>("Week2");

                    b.Property<int>("Week3");

                    b.Property<int>("Week4");

                    b.HasKey("Week1");
                });

            modelBuilder.Entity("ChartingProject.Models.Percent", b =>
                {
                    b.HasOne("ChartingProject.Models.Occupancy")
                        .WithMany()
                        .HasForeignKey("OccupancyMonth");
                });

            modelBuilder.Entity("ChartingProject.Models.Week", b =>
                {
                    b.HasOne("ChartingProject.Models.Occupancy")
                        .WithMany()
                        .HasForeignKey("OccupancyMonth");
                });
        }
    }
}
