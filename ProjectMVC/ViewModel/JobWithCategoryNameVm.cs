using ProjectMVC.Models;

namespace ProjectMVC.ViewModel
{
    public class JobWithCategoryNameVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public string? Image { get; set; }
        public DateTime? DateTime { get; set; }

        public string Description { get; set; }
        public string Type { get; set; } //part time or Full

        public String? Location { get; set; }

        public Double Salary { get; set; }

        public int SelectedCategoryId { get; set; }
        public List<Category>? Categories { get; set; }


        public int? SelectedCompanyId { get; set; }
        public List<Campany>? Companies { get; set; }

    }
}
