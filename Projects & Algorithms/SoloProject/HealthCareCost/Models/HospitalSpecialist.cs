using System;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class HospitalSpecialist
    {
        [Key]
        public int HospitalSpecialistId { get; set; }
        public int HospitalId { get; set; }
        public int SpecialistId { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Hospital Hospital { get; set; }
        public Specialist Specialist { get; set; }
    }
}