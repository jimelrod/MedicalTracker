using System;

namespace Eodg.MedicalTracker.Data.Models
{
    public partial class Medication
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}