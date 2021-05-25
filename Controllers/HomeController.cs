using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.NETCore5DBFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.NETCore5DBFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DBFirstDemoDBContext _dBFirstDemoDBContext;
        public HomeController(DBFirstDemoDBContext dBFirstDemoDBContext ,ILogger<HomeController> logger)
        {
            _dBFirstDemoDBContext = dBFirstDemoDBContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = _dBFirstDemoDBContext.Employees.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
