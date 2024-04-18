using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using System.Diagnostics;

namespace ProjectMVC.Controllers
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
        public IActionResult About()
        {
            return View("About");
        }
        //public IActionResult Category()
        //{
        //    return View("Category");
        //}
        public IActionResult Contact()
        {
            return View("Contact");
        }
        public IActionResult Job_Detail()
        {
            
            return View("Job_Detail");
            
        }
        public IActionResult Apply()
        {
            return View();
        }
        

        //public IActionResult Job_List()
        //{
        //    return View("Job_List");
        //}
        public IActionResult Errors()
        {
            return View("Errors");
        }
        public IActionResult testimonial()
        {
            return View("testimonial");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
