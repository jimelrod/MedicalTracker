using System;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class DosageOccurrence : IActivable, ITimestampable
    {
        public Guid Id { get; set; }
        public Guid MemberMedicationId { get; set; }
        public DateTime OccurredOn { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation Properties
        public MemberMedication MemberMedication { get; set; }
    }
}