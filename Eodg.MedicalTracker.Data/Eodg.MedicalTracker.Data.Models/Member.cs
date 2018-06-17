using System;
using System.Collections.Generic;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class Member : IActivable, ITimestampable
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // TODO: Rest of the goddamn owl...

        // Navigation Properties
        public List<MemberMedication> MemberMedications { get; set; }
        public List<MemberSymptom> MemberSymptoms { get; set; }
    }
}