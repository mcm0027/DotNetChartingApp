using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ChartingProject.Models;

namespace ChartingProject.Migrations.Charting
{
    [DbContext(typeof(ChartingContext))]
    [Migration("20160328180202_ChartingDatabaseChange")]
    partial class ChartingDatabaseChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChartingProject.Models.Occupancy", b =>
                {
                    b.Property<long>("PrimaryTrackingKey")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Label");

                    b.Property<int>("Month");

                    b.Property<float>("Percent");

                    b.Property<int>("Year");

                    b.HasKey("PrimaryTrackingKey");
                });
        }
    }
}
