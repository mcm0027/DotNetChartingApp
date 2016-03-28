using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ChartingProject.Models;

namespace ChartingProject.Migrations.Charting
{
    [DbContext(typeof(ChartingContext))]
    [Migration("20160328025338_OccupancyDatabase")]
    partial class OccupancyDatabase
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

                    b.Property<int>("Weeks");

                    b.Property<int>("percents");

                    b.HasKey("Month");
                });
        }
    }
}
