using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChartingProject.Models
{
    public class Occupancy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OccupanyKey { get; set; } 
        public int Year { get; set; }
        public int Month { get; set; }
        public string Label { get; set; }
        public float Percent { get; set; }
    }
}
