using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
	public class Campany
	{
		public int Id { get; set; }

		[MaxLength(20)]

        [MinLength(2, ErrorMessage = "Name Must be More Than 2 Letter")]

        [Required]
		[UniqueCampany]
		public string Name { get; set; }
        [MinLength(2, ErrorMessage = "Description  Must be More Than 5 Letter")]
        public string Description { get; set; }

		public List<Job>? Jobs { get; set; }

	}
}