using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class Specialist
    {
        [Key]
        public int SpecialistId { get; set; }
        [Required]
        [Display(Name="Specialist First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name="Specialist Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name="Specialist Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name="Specialist Telephone")]        
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "The format should be 04x-xxx-xxx")]
        public string Telephone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        public List<SpecialistSpecialization> Specializations { get; set; }
        public List<HospitalSpecialist> Hospitals { get; set; }

    }
}