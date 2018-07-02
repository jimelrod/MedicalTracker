using Eodg.MedicalTracker.Data.Models;
using Eodg.MedicalTracker.Data.Models.ModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Eodg.MedicalTracker.Data
{
    public class MedicalTrackerContext : DbContext
    {
        public MedicalTrackerContext(DbContextOptions<MedicalTrackerContext> options)
            : base(options)
        {

        }

        public DbSet<DosageOccurrence> DosageOccurrences { get; set; }
        public DbSet<DoseMeasurement> DoseMeasurements { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberMedication> MemberMedications { get; set; }
        public DbSet<MemberSymptom> MemberSymptoms { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<SymptomOccurrence> SymptomOccurrences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DosageOccurrenceConfiguration());
            modelBuilder.ApplyConfiguration(new DoseMeasurementConfiguration());
            modelBuilder.ApplyConfiguration(new MedicationConfiguration());
            modelBuilder.ApplyConfiguration(new MemberConfiguration());
            modelBuilder.ApplyConfiguration(new MemberMedicationConfiguration());
            modelBuilder.ApplyConfiguration(new MemberSymptomConfiguration());
            modelBuilder.ApplyConfiguration(new SymptomConfiguration());
            modelBuilder.ApplyConfiguration(new SymptomOccurrenceConfiguration());
        }
    }
}
