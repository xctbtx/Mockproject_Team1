using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TMS.ClassAdminManagement.Model
{
    public class AdminContext : IdentityDbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<ClassAdmin> ClassAdmins { get; set; }
    }
}
