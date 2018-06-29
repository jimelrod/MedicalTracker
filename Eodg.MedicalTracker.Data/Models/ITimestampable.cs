using System;

namespace Eodg.MedicalTracker.Data.Models
{
    public interface ITimestampable
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}