using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace LoginAndRegistration.Models
{
    public class MyUser : IdentityUser
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}