using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }
        [Required]
        [Display(Name="Specialization Name")]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<SpecialistSpecialization> Specialists { get; set; }
    }
}