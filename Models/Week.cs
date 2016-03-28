using System.ComponentModel.DataAnnotations;

namespace ChartingProject.Models
{
    public class Week
    {
        [Key]
        public string Week1 { get; set; }
        public string Week2 { get; set; }
        public string Week3 { get; set; }
        public string Week4 { get; set; }
    }
}