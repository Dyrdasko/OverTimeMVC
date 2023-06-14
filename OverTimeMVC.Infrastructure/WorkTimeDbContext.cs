using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OverTimeMVC.Domain.Model;

namespace OverTimeMVC.Infrastructure
{
    public class WorkTimeDbContext : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<Holiday> Holidays { get; set; }

        public WorkTimeDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}