using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class DosageOccurrenceConfiguration : IEntityTypeConfiguration<DosageOccurrence>
    {
        // TODO: Figure out default values...
        public void Configure(EntityTypeBuilder<DosageOccurrence> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .HasOne<MemberMedication>(d => d.MemberMedication)
                .WithMany(m => m.DosageOccurrences)
                .HasForeignKey(d => d.MemberMedicationId);

            builder
                .Property(d => d.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(d => d.MemberMedicationId)
                .IsRequired();

            builder
                .Property(d => d.OccurredOn)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder
                .Property(d => d.IsActive)
                .HasDefaultValue(true)
                .IsRequired();
                
            builder
                .Property(d => d.CreatedOn)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder
                .Property(d => d.ModifiedOn)
                .IsRequired();
        }
    }
}