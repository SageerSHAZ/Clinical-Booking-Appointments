using ClinicalBookingAppointments.WebAPI.Modals;
using Microsoft.EntityFrameworkCore;

namespace ClinicalBookingAppointments.WebAPI.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext()
        {
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
