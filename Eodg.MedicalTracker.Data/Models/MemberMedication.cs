using System;
using System.Collections.Generic;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class MemberMedication : IActivable, ITimestampable
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid MedicationId { get; set; }
        public int DoseQuantity { get; set; }
        public Guid DoseMeasurementId { get; set; }
        public int DoseFrequencyInHours { get; set; }
        public int ListingOrder { get; set; }
        public bool HasReminder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation Properties
        public Member Member { get; set; }
        public Medication Medication { get; set; }
        public DoseMeasurement DoseMeasurement { get; set; }
        public List<DosageOccurrence> DosageOccurrences { get; set; }
    }
}