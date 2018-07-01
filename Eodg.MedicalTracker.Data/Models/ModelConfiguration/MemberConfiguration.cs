using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eodg.MedicalTracker.Data.Models.ModelConfiguration
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            #region Entity Configuration

            builder.HasKey(d => d.Id);

            builder.HasAlternateKey(m => m.Email);

            builder
                .HasMany<MemberMedication>(m => m.MemberMedications)
                .WithOne(mm => mm.Member)
                .HasForeignKey(mm => mm.MemberId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany<MemberSymptom>(m => m.MemberSymptoms)
                .WithOne(ms => ms.Member)
                .HasForeignKey(ms => ms.MemberId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region Property Configuration

            builder
                .Property(m => m.Email)
                .IsRequired();

            builder
                .Property(m => m.IsActive)
                .IsRequired();

            builder
                .Property(m => m.CreatedOn)
                .IsRequired();

            builder
                .Property(m => m.ModifiedOn)
                .IsRequired()
                .IsRowVersion();

            #endregion
        }
    }
}