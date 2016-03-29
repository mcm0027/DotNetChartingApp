using System.Collections.Generic;

namespace ChartingProject.Models
{
    public interface IChartistRepository
    {
        IEnumerable<Occupancy> GetOccupancies();
    }
}