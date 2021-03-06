using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ChartingProject.Models;

namespace ChartingProject.Migrations.Charting
{
    [DbContext(typeof(ChartingContext))]
    [Migration("20160328035533_OccupancyDatabase4")]
    partial class OccupancyDatabase4
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OccupancyMonth");

                    b.Property<int>("Percent1");

                    b.Property<int>("Percent2");

                    b.Property<int>("Percent3");

                    b.Property<int>("Percent4");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("ChartingProject.Models.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OccupancyMonth");

                    b.Property<string>("Week1");

                    b.Property<string>("Week2");

                    b.Property<string>("Week3");

                    b.Property<string>("Week4");

                    b.HasKey("Id");
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
