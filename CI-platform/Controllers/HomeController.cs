using CI_platform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI_platform.Controllers
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
        public IActionResult login()
        {
            return View();
        }
        public IActionResult forgot()
        {
            return View();
        }
        public IActionResult newpassword()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        public IActionResult landingpage()
        {
            return View();
        }
        public IActionResult nomission()
        {
            return View();
        }
        public IActionResult Missionpage()
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