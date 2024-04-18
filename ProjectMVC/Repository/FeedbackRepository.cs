using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
	public class FeedbackRepository :Ifeedback
	{
		private Context context;
		public FeedbackRepository(Context _context) {

			context = _context;
		}

		public List<Feedback> GetAll()
        {
            return context.Feedbacks.ToList();
        }

        public void Add(Feedback feedback)
        {
            context.Add(feedback);
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
