using Microsoft.EntityFrameworkCore;

namespace TMS.ClassAdminManagement.Model
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options){}
        public DbSet<ClassAdmin> ClassAdmins { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<ClassBatch> ClassBatches { get; set; }
    }
}
