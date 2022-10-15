using gitAss1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace gitAss1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public string getname()
        {
            return "Basavaraj Loni";

        }

        public string getAge(int age)
        {
            return "Name: Basavaraj Loni, Age:" + age;
        }
        public string getusername(string uid)
        {
            return "Name: Basavaraj Loni, user id:" + uid;
        }
        public ViewResult Contactus(string uid)
        {
            return View();
        }
    }
}
