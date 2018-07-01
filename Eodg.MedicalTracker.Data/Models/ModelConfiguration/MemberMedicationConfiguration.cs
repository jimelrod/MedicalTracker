using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class MemberMedicationConfiguration : IEntityTypeConfiguration<MemberMedication>
    {
        public void Configure(EntityTypeBuilder<MemberMedication> builder)
        {
            #region Entity Configuration

            builder.HasKey(m => m.Id);

            builder
                .HasMany<DosageOccurrence>(m => m.DosageOccurrences)
                .WithOne(d => d.MemberMedication)
                .HasForeignKey(d => d.MemberMedicationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne<Member>(mm => mm.Member)
                .WithMany(m => m.MemberMedications)
                .HasForeignKey(mm => mm.MemberId);

            builder
                .HasOne<Medication>(mm => mm.Medication)
                .WithMany(m => m.MemberMedications)
                .HasForeignKey(mm => mm.MedicationId);

            builder
                .HasOne<DoseMeasurement>(mm => mm.DoseMeasurement)
                .WithMany(dm => dm.MemberMedications)
                .HasForeignKey(mm => mm.DoseMeasurementId);

            #endregion

            #region Property Configuration

            builder
                .Property(mm => mm.Id)
                .IsRequired();

            builder
                .Property(mm => mm.MemberId)
                .IsRequired();

            builder
                .Property(mm => mm.MedicationId)
                .IsRequired();

            builder
                .Property(mm => mm.DoseQuantity)
                .IsRequired();

            builder
                .Property(mm => mm.DoseMeasurementId)
                .IsRequired();

            builder
                .Property(mm => mm.DoseFrequencyInHours)
                .IsRequired();

            builder
                .Property(mm => mm.ListingOrder)
                .IsRequired();

            builder
                .Property(mm => mm.HasReminder)
                .IsRequired();

            builder
                .Property(mm => mm.IsActive)
                .IsRequired();

            builder
                .Property(mm => mm.CreatedOn)
                .IsRequired();

            builder
                .Property(mm => mm.ModifiedOn)
                .IsRequired();
            
            #endregion
        }
    }
}