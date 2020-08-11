using Microsoft.EntityFrameworkCore;

namespace TMS.ClassAdminManagement.Model
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminMap>().HasKey(a => new { a.ClassAdminId, a.ClassId });
            modelBuilder.Entity<TrainerMap>().HasKey(b => new {b.TrainerId , b.ClassId});
        }
        public DbSet<ClassAdmin> ClassAdmins { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<ClassBatch> ClassBatches { get; set; }
        public DbSet<AdminMap> AdminMaps { get; set; }
        public DbSet<TrainerMap> TrainerMaps { get; set; }
    }
}
