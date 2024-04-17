using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public class CampanyRepository:ICampany
    {
        Context context;

        public string Id { get; set; }

        public CampanyRepository(Context _context)
        {

            Id = Guid.NewGuid().ToString();
            context = _context;
        }
        public List<Campany> GetAll()
        {
            return context.Companys.ToList();
        }
        public Campany GetById(int id)
        {
            return context.Companys.FirstOrDefault(e => e.Id == id);
        }
        public void Insert(Campany obj)
        {
            context.Add(obj);
        }
        public void Update(Campany obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
           Campany company = GetById(id);
            if (company != null)
            {
                context.Companys.Remove(company);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}


    

