using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
	public interface Ifeedback
	{
		public List<Feedback> GetAll();
		public void Add(Feedback feedback);
		public void Save();

	}
}
