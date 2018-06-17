using System;
using System.Collections.Generic;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class MemberSymptom : IActivable, ITimestampable
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid SymptomId { get; set; }
        public int ListingOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation Properties
        public Member Member { get; set; }
        public Symptom Symptom { get; set; }
        public List<SymptomOccurrence> SymptomOccurrences { get; set; }
    }
}