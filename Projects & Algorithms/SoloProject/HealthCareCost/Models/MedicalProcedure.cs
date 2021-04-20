using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class MedicalProcedure
    {
        [Key]
        public int MedicalProcedureId { get; set; }
        [Required]
        [Display(Name="Medical Service Name")]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<HospitalMedicalProcedure> Hospitals { get; set; }
    }
}