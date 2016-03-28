using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartingProject.Models
{
    public class ChartingContextSeedData
    {
        private ChartingContext _context;

        public ChartingContextSeedData(ChartingContext context)
        {
            _context = context;

        }

        public void EnsureSeedData()
        {
            if (!_context.Occupancies.Any())
            {
                var juneWeek1 = new Occupancy()
                {
                    Year = 2016,
                    Month = 1,
                    Label = "Week 1",
                    Percent = 56
                    
                };

                _context.Occupancies.Add(juneWeek1);

                _context.SaveChanges();
            }
        }
    }
}
