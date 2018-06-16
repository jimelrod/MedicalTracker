using Eodg.MedicalTracker.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Eodg.MedicalTracker.Data
{
    public class MedicalTrackerContext : DbContext
    {
        public DbSet<DosageOccurrence> DosageOccurrences { get; set; }
        public DbSet<DoseMeasurement> DoseMeasurements { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberMedication> MemberMedications { get; set; }
        public DbSet<MemberSymptom> MemberSymptoms { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<SymptomOccurrence> SymptomOccurences { get; set; }
    }
}
