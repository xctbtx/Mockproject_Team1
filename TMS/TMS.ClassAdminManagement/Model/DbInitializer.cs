using System.Linq;

namespace TMS.ClassAdminManagement.Model
{
    public class DbInitializer
    {
        public static void Seed(AdminContext context)
        {
            context.Database.EnsureCreated();
            if (context.ClassAdmins.Any())
            {
                return;
            }

            var classAdmins = new ClassAdmin[]
            {
                new ClassAdmin() {Account = "Daisies"},
                new ClassAdmin() {Account = "Lilies"},
                new ClassAdmin() {Account = "Orchids"},
                new ClassAdmin() {Account = "Roses"},
                new ClassAdmin() {Account = "Sunflower"},
            };
            context.ClassAdmins.AddRange(classAdmins);

            var trainers = new Trainer[]
            {
                new Trainer(){}
            };
            context.Trainers.AddRange(trainers);

            var classBatches = new ClassBatch[]
            {
                new ClassBatch(){}
            };
            context.ClassBatches.AddRange(classBatches);

            context.SaveChanges();
        }
    }
}
