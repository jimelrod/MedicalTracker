using Eodg.MedicalTracker.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Eodg.MedicalTracker.Data
{
    public class MedicalTrackerContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
