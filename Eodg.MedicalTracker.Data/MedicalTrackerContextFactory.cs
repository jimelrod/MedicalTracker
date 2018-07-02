using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Eodg.MedicalTracker.Data
{
    public class MedicalTrackerContextFactory : IDesignTimeDbContextFactory<MedicalTrackerContext>
    {
        public MedicalTrackerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MedicalTrackerContext>();

            var connectionString = Environment.GetEnvironmentVariable("MedicalTrackerDbConnectionString");

            optionsBuilder.UseSqlServer(connectionString);

            return new MedicalTrackerContext(optionsBuilder.Options);
        }
    }
}