using System;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class MedicalService
    {
        [Key]
        public int MedicalServiceId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public double Cost { get; set; }
        public int HospitalMedicalProcedureId { get; set; }
        public int HospitalSpecialistId { get; set; }
        public int SpecialistSpecializationId { get; set; }

        public HospitalMedicalProcedure HospitalMedicalProcedure { get; set; }
        public HospitalSpecialist HospitalSpecialist { get; set; }
        public SpecialistSpecialization SpecialistSpecialization { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}