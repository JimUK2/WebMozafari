using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMozafari.Models;

namespace WebMozafari.Controllers
{
    public class HomeController : Controller
    {
      

        

        public IActionResult Index()
        {
            var xxx = 10;
            Random r = new Random();
            var x = r.Next(600);
            var y = r.Next(500);
            //welcome name famil sen old from city
            ViewBag.y = y;
            ViewBag.x = x;
            ViewBag.sum = x + y;



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
