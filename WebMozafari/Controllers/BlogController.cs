using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMozafari.Models;

namespace WebMozafari.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}