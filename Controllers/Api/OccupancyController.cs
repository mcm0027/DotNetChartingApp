using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ChartingProject.Controllers.Api
{
    public class OccupancyController : Controller
    {


        [HttpGet("api/occupancy")]
        public JsonResult Get()
        {
            return Json(new { name = "Matt" });
        }
    }
}
