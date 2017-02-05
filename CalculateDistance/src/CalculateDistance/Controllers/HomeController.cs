using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculateDistance.Model;
using Microsoft.AspNetCore.Mvc;

namespace CalculateDistance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Geocode(Address address)
        {

            return View("DefaultIndex");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
