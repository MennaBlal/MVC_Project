using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using ProjectMVC.Repository;
using ProjectMVC.ViewModel;

namespace ProjectMVC.Controllers
{
    public class CampanyController : Controller
    {
        ICampany _CompanyRepository;
        IJob _JobRepository;

        public CampanyController(ICampany CompanyRepository, IJob JobRepository)
        {
            _CompanyRepository = CompanyRepository;
            _JobRepository = JobRepository;
        }

        public IActionResult Index()
        {

            List<Campany> comListModel = _CompanyRepository.GetAll();
            return View("Index", comListModel);

        }
        public IActionResult GetJobByCatID(int comID)
        {
            var companys = _JobRepository.GetByCatID(comID)
                .Select(e => new { e.Name, e.Id }).ToList();

            return Json(companys);

        }
        public IActionResult CampaniesJob(int CompanyId)
        {
            List<Job> jobs = _JobRepository.GetAll().Where(j => j.CompanyId == CompanyId).ToList();

            return View("CampaniesJob", jobs);
        }
        [HttpGet]
        public IActionResult New()
        {
            return View("New");
        }
        [HttpPost]
        public IActionResult SaveNEw(Campany company)
        {
            if (ModelState.IsValid == true)
            {
                try
                {
            if (company.Name != null && company.Description != null)
            {
                _CompanyRepository.Insert(company);
                _CompanyRepository.Save();

                return RedirectToAction("Index");
            }
                    else
                    {
                        ModelState.AddModelError("error", "Name and Description cannot be null");
            return View("New", company);
        }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("error", ex.InnerException.Message);
                    return View("New", company);
                }
            }
            else
            {
                return View("New", company);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Campany company = _CompanyRepository.GetById(id);
            if (company == null)
                return NotFound("Company Not Found");

            campanymodel comVM = new campanymodel();
            comVM.Id = company.Id; // Ensure to set the Id in the view model
            comVM.Name = company.Name;
            comVM.Description = company.Description;
            comVM.Jobs = company.Jobs;

            return View("Edit", comVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(campanymodel comview)
        {
            if (comview.Name != null && comview.Description != null)
            {
                // Retrieve the existing company from the repository
                Campany existingCompany = _CompanyRepository.GetById(comview.Id);

                if (existingCompany == null)
                {
                    return NotFound("Company Not Found");
                }

                existingCompany.Name = comview.Name;
                existingCompany.Description = comview.Description;

                _CompanyRepository.Update(existingCompany);
                _CompanyRepository.Save(); // Assuming Save() persists changes to the database

                return RedirectToAction("Index");
            }
            return View("Edit", comview);
        }
        public IActionResult Delete(int id)
        {
            _CompanyRepository.Delete(id);
            _CompanyRepository.Save();
            return RedirectToAction("Index");

        }
    }
}

