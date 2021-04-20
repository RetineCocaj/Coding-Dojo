using System;
using System.ComponentModel.DataAnnotations;

namespace HealthCareCost.Models
{
    public class HospitalMedicalProcedure
    {
        [Key]
        public int HospitalMedicalProcedureId { get; set; }
        public int HospitalId { get; set; }
        public int MedicalProcedureId { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Hospital Hospital { get; set; }
        public MedicalProcedure MedicalProcedure { get; set; }
    }
}