using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class MedicationConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure(EntityTypeBuilder<Medication> builder)
        {
            builder.HasKey(m => m.Id);

            builder
                .HasMany<MemberMedication>(m => m.MemberMedications)
                .WithOne(mm => mm.Medication)
                .HasForeignKey(m => m.MedicationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(m => m.Id)
                .IsRequired();

            builder
                .Property(m => m.Name)
                .IsRequired();

            builder
                .Property(m => m.Description)
                .IsRequired();
        }
    }
}