using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
	public interface ICampany
	{
        public List<Campany> GetAll();//string includes=null)


        public Campany GetById(int id);

        public void Insert(Campany obj);

       public void Update(Campany obj);

        public void Delete(int id);

        public void Save();

    }
}
