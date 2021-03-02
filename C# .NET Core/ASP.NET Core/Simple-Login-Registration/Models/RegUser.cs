using System.ComponentModel.DataAnnotations;
namespace Simple_Login_Registration.Models
{
    public class RegUser
    {
        [Display(Name="First Name")]
        [Required]
        [MinLength(2, ErrorMessage="Field must be 2 characters or more")]
        public string FirstName{ get; set; }

        [Display(Name="Last Name")]
        [Required]
        [MinLength(2, ErrorMessage="Field must be 2 characters or more")]
        public string LastName{ get; set; }

        [Display(Name="Email")]
        [Required]
        [EmailAddress]
        public string Email{ get; set; }

        [DataType(DataType.Password)]
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15}$", 
        ErrorMessage = "Password must be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.")]
        public string Password{ get; set; }

        [Display(Name="Confirm Password")]
        [DataType(DataType.Password)]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword{ get; set; } 
    }
}