using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudioFlow.Models;

namespace StudioFlow.Data
{
    public class StudioFlowDbContext : IdentityDbContext
    {
        // Constructor to pass options to the base class
        public StudioFlowDbContext(DbContextOptions<StudioFlowDbContext> options)
            : base(options)
        {
        }

        // DbSet properties to map to database tables
        public DbSet<Event> Events { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Financial> Financials { get; set; }
        public DbSet<EventStatus> EventStatuses { get; set; }
    }
}
