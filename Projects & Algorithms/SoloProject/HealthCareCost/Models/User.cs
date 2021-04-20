using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HealthCareCost.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [AgeValidator(18)]
        [Display(Name="Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*?[A-Za-z])(?=.*?[0-9])(?=.*?[+#?!@$%^&*-]).{8,}$", 
        ErrorMessage = "Password must be at least of length 8 and must include at least one letter, one numeric digit and a special character.")]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }

        public string Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

    public class LoginUser
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string EmailAttempt { get; set; } 
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string PasswordAttempt { get; set; }
    }
}