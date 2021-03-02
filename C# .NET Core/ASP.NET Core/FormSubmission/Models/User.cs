using System;
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{
    public class User
    {
        [Display(Name="First Name")]
        [Required]
        [MinLength(3, ErrorMessage="Field must be 3 characters or more")]
        public string FirstName{ get; set; }

        [Display(Name="Last Name")]
        [Required]
        [MinLength(3, ErrorMessage="Field must be 3 characters or more")]
        public string LastName{ get; set; }

        [Display(Name="Age")]
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage="Age must be a positive number")]
        public int Age{ get; set; }

        [Display(Name="Email Address")]
        [Required]
        [EmailAddress]
        public string EmailAddress{ get; set; }

        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15}$", 
        ErrorMessage = "Password must be at least 8 characters, no more than 15 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.")]
        public string Password{ get; set;}
    }
}