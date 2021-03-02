using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models
{
    public class Survey
    {
        [Display(Name = "Name:")]
        [Required]
        [MinLength(2, ErrorMessage="Field must be 2 characters or more")]
        public string Name{get; set;}

        [Display(Name = "Location:")]
        [Required]
        public string Location{get; set;}

        [Display(Name = "Language:")]
        [Required]
        public string Language{get; set;}

        [Display(Name = "Comment (optional):")]
        [MaxLength(20, ErrorMessage="Field must be no more than 20 characters")]
        public string Comment{get; set;}
    }
}
