using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartingProject.Models
{
    public class ChartingContext : DbContext
    {
        public DbSet<Occupancy> Occupancies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\ProjectsV12;Database=ChartingDB;Trusted_Connection=true;MultipleActiveResultSets=true;";

            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
