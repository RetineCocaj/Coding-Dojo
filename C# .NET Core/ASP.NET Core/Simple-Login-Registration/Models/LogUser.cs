using System.ComponentModel.DataAnnotations;
namespace Simple_Login_Registration.Models
{
    public class LogUser
    {
        [Display(Name="Email")]
        [Required]
        [EmailAddress]
        public string LoginEmail{ get; set; }

        [DataType(DataType.Password)]
        [Display(Name="Password")]
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15}$", 
        ErrorMessage = "Password must be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.")]
        public string LoginPassword{ get; set; }

    }
}