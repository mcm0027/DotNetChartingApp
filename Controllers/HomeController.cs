﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ChartingProject.Models;

namespace ChartingProject.Controllers
{
    public class HomeController : Controller
    {
        private IChartistRepository _repository;

        public HomeController(IChartistRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Occupancy()
        {
            ViewData["Message"] = "The average occupancy rate by week.";
            var occupancies = _repository.GetOccupancies();

            return View(occupancies);
        }

        public IActionResult NewToOld()
        {
            ViewData["Message"] = "The percentage of appartments occupied by new tenates, existing tenates and unoccupied units.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
