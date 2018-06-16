using System;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class MemberSymptom
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid SymptomId { get; set; }
        public int ListingOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}