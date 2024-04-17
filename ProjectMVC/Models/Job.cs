using System.ComponentModel.DataAnnotations.Schema;
namespace ProjectMVC.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string? Responsibility { get; set; }
        public string? Qualifications { get; set; }
        public string? Image { get; set; }
        public DateTime? DateTime { get; set; }

        public string Description { get; set; }
        public string Type { get; set; } //part time or Full

        public String? Location { get; set; }

        public Double Salary { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


        [ForeignKey("Company")]
        public int? CompanyId { get; set; }
        public Campany? Company { get; set; }




    }
}