using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CalculateDistance.Model;
using Microsoft.AspNetCore.Mvc;

namespace CalculateDistance.Controllers
{
    public class HomeController : Controller
    {
        private static string requestApiKey = "&key=AIzaSyDfcp2B-7DJlmnclu-AE16c0sTitiJlRqE";
        private static string baseUrl = "https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins=";
        private static string origin = "4404+Old+Sterlington+Rd,+Monroe,+LA+71203";
        private static string dest = "330+Marshall+Street,+Shreveport,+LA";

        private static string test = $"https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins=Washington,DC&destinations=New+York+City,NY{requestApiKey}";

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateDistance(Transit transit)
        {
            //string request = $"{baseUrl}{origin}&destinations={dest}{requestApiKey}";
            var response = MakeRequest();
                    

            return View("DefaultIndex");
        }

        private string MakeRequest()
        {
            using (var client = new HttpClient())
            {
                //return await client.GetStringAsync(WebUtility.UrlEncode(request));                
                return client.GetStringAsync($"{baseUrl}{origin}&destinations={dest}{requestApiKey}").Result;
            }
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
