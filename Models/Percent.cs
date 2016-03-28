using System.ComponentModel.DataAnnotations;

namespace ChartingProject.Models
{
    public class Percent
    {
        [Key]
        public int Percent1 { get; set; }
        public int Percent2 { get; set; }
        public int Percent3 { get; set; }
        public int Percent4 { get; set; }
    }
}