using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public class SearchAboutRepository
    {
        Context DbContext { get; set; }
        public SearchAboutRepository(Context _context)
        {

            DbContext = _context;
        }
        public List<Job> Search(string JobName ,int CategoryId, string Position)      
        {
            if (!JobName.IsNullOrEmpty() || CategoryId > 0 || !Position.IsNullOrEmpty())
            {
                List<Job> jobs = (DbContext.Jobs.Where(J => J.Name.Contains(JobName)
                || (J.CategoryId == CategoryId) || (J.Position == Position)).OrderByDescending(j => j.DateTime).ToList());

                
                return jobs;

            }
            return null;

        }
    }
}
