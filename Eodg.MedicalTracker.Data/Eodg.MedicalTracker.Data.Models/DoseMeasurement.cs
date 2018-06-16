using System;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class DoseMeasurement
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}