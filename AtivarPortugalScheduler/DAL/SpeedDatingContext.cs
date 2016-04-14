using AtivarPortugalScheduler.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AtivarPortugalScheduler.DAL
{
    public class SpeedDatingContext : DbContext
    {
        public SpeedDatingContext() : base("SpeedDatingContext")
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<StartupM> StartupMs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}