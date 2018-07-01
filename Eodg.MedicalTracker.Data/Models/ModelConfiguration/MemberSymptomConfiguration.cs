using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class MemberSymptomConfiguration : IEntityTypeConfiguration<MemberSymptom>
    {
        public void Configure(EntityTypeBuilder<MemberSymptom> builder)
        {
            #region Entity Configuration

            builder.HasKey(m => m.Id);

            builder
                .HasMany<SymptomOccurrence>(ms => ms.SymptomOccurrences)
                .WithOne(so => so.MemberSymptom)
                .HasForeignKey(so => so.MemberSymptomId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne<Member>(ms => ms.Member)
                .WithMany(m => m.MemberSymptoms)
                .HasForeignKey(ms => ms.MemberId);

            builder
                .HasOne<Symptom>(ms => ms.Symptom)
                .WithMany(s => s.MemberSymptoms)
                .HasForeignKey(ms => ms.SymptomId);

            #endregion

            #region Property Configuration

            builder
                .Property(ms => ms.Id)
                .IsRequired();

            builder
                .Property(ms => ms.MemberId)
                .IsRequired();

            builder
                .Property(ms => ms.SymptomId)
                .IsRequired();

            builder
                .Property(ms => ms.ListingOrder)
                .IsRequired();
                
            builder
                .Property(ms => ms.IsActive)
                .IsRequired();

            builder
                .Property(ms => ms.CreatedOn)
                .IsRequired();

            builder
                .Property(ms => ms.ModifiedOn)
                .IsRequired();
            
            #endregion
        }
    }
}