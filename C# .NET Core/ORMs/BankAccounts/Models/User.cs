using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Display(Name="First Name")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name="Last Name")]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword {get;set;}

        public List<Transaction> Transactions {get;set;} = new List<Transaction>();

        [Range(0, int.MaxValue)]
        public double Balance
        {
            get { return Transactions.Sum(t => t.Amount);}
        }
    }



    public class LoginUser
    {
        [EmailAddress]
        [Required]
        [Display(Name="Email")]
        public string EmailAttempt {get;set;}
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string PasswordAttempt {get;set;}
    }
}