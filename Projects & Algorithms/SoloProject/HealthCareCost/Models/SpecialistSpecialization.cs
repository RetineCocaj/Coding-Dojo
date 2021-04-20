using System;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class SpecialistSpecialization
    {
        [Key]
        public int SpecialistSpecializationId { get; set; }
        public int SpecialistId { get; set; }
        public int SpecializationId { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Specialist Specialist { get; set; }
        public Specialization Specialization { get; set; }
    }
}