using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
	public class Feedback
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="This Field is Required")]
		public string Message { get; set; }

		[ForeignKey("User")]
        [Required]
        public string? UserId { get; set; }
		public ApplicationUser? User { get; set; }
	}
}
