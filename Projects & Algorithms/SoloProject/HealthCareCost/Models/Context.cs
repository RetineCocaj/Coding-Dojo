using Microsoft.EntityFrameworkCore;

namespace HealthCareCost.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options){}
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<SpecialistSpecialization> SpecialistSpecializations { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalSpecialist> HospitalSpecialist { get; set; }
        public DbSet<MedicalProcedure> MedicalProcedures { get; set; }
        public DbSet<HospitalMedicalProcedure> HospitalMedicalProcedures { get; set; }
        public DbSet<MedicalService> MedicalServices { get; set; }

        public DbSet<User> Users { get; set; }

    }
}