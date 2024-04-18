using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public interface IJob
    {
        public List<Job> GetAll();
        public Job GetById(int id);
        public List<Job> GetFullTimeJob();
        public List<Job> GetPartTimeJob();
        public void Insert(Job obj);
        public void Update(Job obj);
        public void Delete(int id);
        public List<Job> GetByCatID(int catID);
        public void Save();

    }
}
