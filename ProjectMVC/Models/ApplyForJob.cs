using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
	public class ApplyForJob
	{
		public int Id { get; set; }

		[ForeignKey("Job")]
		public int JobId { get; set; }
		public Job Job { get; set; }

		[ForeignKey("User")]
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }
		public DateTime DateTime { get; set; }
		public string Description { get; set; }

		[Display(Name = "Upload CV ")]
		public string FilePath {  get; set; }
	}
}
