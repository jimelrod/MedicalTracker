using System;
using System.Collections.Generic;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class DoseMeasurement
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public List<MemberMedication> MemberMedications { get; set; }
    }
}