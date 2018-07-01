using System;
using System.Collections.Generic;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class Symptom
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public List<MemberSymptom> MemberSymptoms { get; set; }
    }
}