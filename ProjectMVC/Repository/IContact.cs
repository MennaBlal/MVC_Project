using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public interface IContact
    {
        public void Add(Contact contact);
        public void Save();
    }
}
