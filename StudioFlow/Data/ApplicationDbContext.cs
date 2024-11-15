using Microsoft.EntityFrameworkCore;
using StudioFlow.Models;

namespace StudioFlow.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
    }
}