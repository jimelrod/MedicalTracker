using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class DosageOccurrenceConfiguration : IEntityTypeConfiguration<DosageOccurrence>
    {
        public void Configure(EntityTypeBuilder<DosageOccurrence> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .HasOne<MemberMedication>(d => d.MemberMedication)
                .WithMany(m => m.DosageOccurrences)
                .HasForeignKey(d => d.MemberMedicationId);

            builder
                .Property(d => d.Id)
                .IsRequired();

            builder
                .Property(d => d.MemberMedicationId)
                .IsRequired();

            builder
                .Property(d => d.OccurredOn)
                .IsRequired();

            builder
                .Property(d => d.IsActive)
                .IsRequired();
                
            builder
                .Property(d => d.CreatedOn)
                .IsRequired();

            builder
                .Property(d => d.ModifiedOn)
                .IsRequired()
                .IsRowVersion();
        }
    }
}