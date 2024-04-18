using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public class ContactRepository:IContact
    {
        Context dbcontext;
       public  ContactRepository(Context context)
        {

            dbcontext = context;

        }
        public void Add(Contact contact)
        {

            dbcontext.Add(contact);
        }
        public void Save()
        {
            dbcontext.SaveChanges();
        }
    }
}
