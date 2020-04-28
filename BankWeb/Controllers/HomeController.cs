using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BankServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BankWeb.Models;

namespace BankWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculator _calculator;

        public HomeController(ILogger<HomeController> logger, ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            int a = _calculator.Add(12, 13);
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
