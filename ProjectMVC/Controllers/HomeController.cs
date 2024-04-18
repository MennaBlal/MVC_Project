using Microsoft.AspNetCore.Mvc;
using ProjectMVC.DTO;
using ProjectMVC.Models;
using ProjectMVC.Repository;
using System.Diagnostics;

namespace ProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ICategory CategoryRepository { get; set; }
        public IJob JobRepository { get; set; }
        public HomeController(ILogger<HomeController> logger, ICategory _categoryRepository, IJob _jobRepository)
        {
            this.CategoryRepository = _categoryRepository;
            this.JobRepository = _jobRepository;
           
            _logger = logger;
        }

        public IActionResult Index()
        {

            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Categories = this.CategoryRepository.GetAll();
            homeViewModel.Jobs = this.JobRepository.GetAll();

            return View("Index", homeViewModel);
         }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View("About");
        }
        public IActionResult Category()
        {
            return View("Category");
        }
       
        public IActionResult Job_Detail()
        {
            return View("Job_Detail");
        }
        public IActionResult Job_List()
        {
            return View("Job_List");
        }
        public IActionResult Errors()
        {
            return View("Errors");
        }
        //public IActionResult testimonial()
        //{
        //    return View("");
        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
