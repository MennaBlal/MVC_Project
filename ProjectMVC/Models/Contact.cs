using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress ,ErrorMessage ="Please Enter The Vaild Email")]
        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }
        public string? Subject { get; set; }
        public string Message { get; set; }

    }
}
