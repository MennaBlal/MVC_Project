using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using ProjectMVC.Repository;

namespace ProjectMVC.Controllers
{
    public class ContactController : Controller
    {
        private IContact contactRepository;

        public ContactController(IContact contactRepository)
        {
            this.contactRepository = contactRepository;

        }
        public IActionResult Index()
        {
            return View("Contact");
        }

        public IActionResult Add(Contact newContact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contactRepository.Add(newContact);
                    contactRepository.Save();
                     return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

            }
            
            return View("Contact", newContact);

        }
    }
}
