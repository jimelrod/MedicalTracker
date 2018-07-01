using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class DoseMeasurementConfiguration : IEntityTypeConfiguration<DoseMeasurement>
    {
        public void Configure(EntityTypeBuilder<DoseMeasurement> builder)
        {
            builder.HasKey(d => d.Id);

            builder
                .HasMany<MemberMedication>(d => d.MemberMedications)
                .WithOne(mm => mm.DoseMeasurement)
                .HasForeignKey(mm => mm.DoseMeasurementId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(d => d.Id)
                .IsRequired();

            builder
                .Property(d => d.Name)
                .IsRequired();

            builder
                .Property(d => d.Abbreviation)
                .IsRequired();
        }
    }
}