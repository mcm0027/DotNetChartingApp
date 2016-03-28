using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChartingProject.Models
{
    public class Occupancy
    {
        [Key]
        public string Month { get; set; }
        public ICollection<Week> Weeks { get; set; }
        public ICollection<Percent> Percents { get; set; }
        public int Id { get; set; }
    }
}
