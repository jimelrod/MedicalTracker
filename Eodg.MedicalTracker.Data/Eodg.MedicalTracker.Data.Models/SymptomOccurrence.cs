using System;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class SymptomOccurrence
    {
        public Guid Id { get; set; }
        public Guid MemberSymptomId { get; set; }
        public DateTime OccurredOn { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}