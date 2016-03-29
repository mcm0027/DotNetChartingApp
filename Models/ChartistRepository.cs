using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartingProject.Models
{
    public class ChartistRepository : IChartistRepository
    {
        private ChartingContext _context;

        public ChartistRepository(ChartingContext context)
        {
            _context = context;
        }

        public IEnumerable<Occupancy> GetOccupancies()
        {
            return _context.Occupancies.OrderBy(t => t.Month).ToList();
        }
    }
}
