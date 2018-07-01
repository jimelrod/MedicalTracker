using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class SymptomConfiguration : IEntityTypeConfiguration<Symptom>
    {
        public void Configure(EntityTypeBuilder<Symptom> builder)
        {
            builder.HasKey(m => m.Id);

            builder
                .HasMany<MemberSymptom>(s => s.MemberSymptoms)
                .WithOne(ms => ms.Symptom)
                .HasForeignKey(ms => ms.SymptomId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(s => s.Id)
                .IsRequired();

            builder
                .Property(s => s.Name)
                .IsRequired();

            builder
                .Property(s => s.Description)
                .IsRequired();
        }
    }
}