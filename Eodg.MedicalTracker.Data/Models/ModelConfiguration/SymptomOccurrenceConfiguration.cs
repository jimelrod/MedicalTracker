using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class SymptomOccurrenceConfiguration : IEntityTypeConfiguration<SymptomOccurrence>
    {
        public void Configure(EntityTypeBuilder<SymptomOccurrence> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .HasOne<MemberSymptom>(d => d.MemberSymptom)
                .WithMany(m => m.SymptomOccurrences)
                .HasForeignKey(d => d.MemberSymptomId);

            builder
                .Property(d => d.Id)
                .IsRequired();

            builder
                .Property(d => d.MemberSymptomId)
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