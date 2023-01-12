using System.Diagnostics;
using DrivingSchool.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrivingSchool.Controllers
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
        public IActionResult cars()
        {
            return View();
        }

		public IActionResult admin()
		{
			return View();
		}
		public IActionResult StudentLogin()
		{
			return View();
		}
        public IActionResult Design()
        {
            return View();
        }
        public IActionResult combine()
        {
            return View();
        }


        public IActionResult InstructorLogin()
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