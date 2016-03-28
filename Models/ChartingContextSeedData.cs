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
                var june = new Occupancy()
                {
                    Month = "June",
                    Weeks = new List<Week>()
                    {
                        new Week() { Week1 = "Week 1" },
                        new Week() { Week2 = "Week 2" },
                        new Week() { Week3= "Week 3" },
                        new Week() { Week4 = "Week 4" }
                    }
                    ,
                    Percents = new List<Percent>()
                    {
                        new Percent() { Percent1 = 95 },
                        new Percent() { Percent2 = 65 },
                        new Percent() { Percent3 = 55 },
                        new Percent() { Percent4 = 88 },
                    }
                };

                //_context.Occupancies.Add(june);
                //_context.Weeks.AddRange(june.Weeks);
                //_context.Percents.AddRange(june.Percents);

                //_context.SaveChanges();
            }
        }
    }
}
