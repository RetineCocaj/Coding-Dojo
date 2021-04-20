using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        [Required]
        [Display(Name="Hospital Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name="Hospital Email")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "The format should be 04x-xxx-xxx")]
        [Display(Name="Hospital Telephone")]
        public string Telephone { get; set; }
        [Required]
        [Display(Name="Hospital Address")]
        public string Address { get; set; }
        public string Website { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<HospitalSpecialist> Specialists { get; set; }
        public List<HospitalMedicalProcedure> MedicalProcedures { get; set; }

    }
}