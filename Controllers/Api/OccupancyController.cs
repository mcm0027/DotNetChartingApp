using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ChartingProject.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ChartingProject.Controllers.Api
{
    [Route("api/occupancy")]
    public class OccupancyController : Controller
    {
        private IChartistRepository _repository;

        public OccupancyController(IChartistRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public JsonResult Get()
        {
            var results = _repository.GetOccupancies();
            return Json(results);
        }

        [HttpPost("")]
        public JsonResult Post([FromBody]Occupancy newOccupancy)
        {
            return Json(true);
        }
    }
}
