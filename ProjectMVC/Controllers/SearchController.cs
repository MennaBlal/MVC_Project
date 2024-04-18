using Microsoft.AspNetCore.Mvc;
using ProjectMVC.DTO;
using ProjectMVC.Models;
using ProjectMVC.Repository;

namespace ProjectMVC.Controllers
{
    public class SearchController : Controller
    {
        public SearchAboutRepository SearchAboutRepository { get; set; }
        
        public SearchController(SearchAboutRepository _searchAboutRepository)
        {
            this.SearchAboutRepository = _searchAboutRepository;
            
        }

        
        public IActionResult Search(string JobName, int CategoryId, string Position)
        {

            List<Job> Jobs = this.SearchAboutRepository.Search(JobName, CategoryId, Position);
            return Json(Jobs);
        }
    }
}
