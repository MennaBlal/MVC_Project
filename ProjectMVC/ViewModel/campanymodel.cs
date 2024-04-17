using ProjectMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.ViewModel
{
    public class campanymodel
    {
        public int Id { get; set; }
        //[Display ('Name of Company')]
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Job> Jobs { get; set; }

    }
}
