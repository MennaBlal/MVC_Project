using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using ProjectMVC.Repository;
using System.Security.Claims;
using System.Security.Principal;

namespace ProjectMVC.Controllers
{
    public class FeedbackController : Controller
    {

        private Ifeedback feedbackReopsitory;
        //UserManager<ApplicationUser> userManager;

        public FeedbackController(Ifeedback feedbackReopsitory )
        {
            this.feedbackReopsitory = feedbackReopsitory;
         }
        
        //public IActionResult Index()
        //{
        //    //List<Feedback> feedbacks = feedbackReopsitory.GetAll();
        //    //ViewBag.feedbacks = feedbacks;

        //    //Claim ClaimUser = User.Claims.FirstOrDefault(U => U.Type == ClaimTypes.NameIdentifier);
        //    //ViewBag.userid = ClaimUser.Value;

        //    //return View("Index");
        // }

        [HttpPost]
        public IActionResult Add(Feedback NewFeedback)
        {
            if (ModelState.IsValid)
            {
                try
                { 
                    feedbackReopsitory.Add(NewFeedback);
                    feedbackReopsitory.Save();
                    return RedirectToAction("Index");


                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }

            }

            return View("Index" , NewFeedback);

            
            
        }

     }
}
