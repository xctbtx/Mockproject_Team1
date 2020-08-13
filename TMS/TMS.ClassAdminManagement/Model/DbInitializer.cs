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
                new ClassAdmin(){FullName="Aaron Stanley",DateOfBirth =new System.DateTime(1998,03,23),Gender=true,PhoneNumber = "0943116030",Email="suscipit.nonummy@Proin.org",Account="Allistair" },
                new ClassAdmin(){FullName="Aidan Barron",DateOfBirth =new System.DateTime(1993,4,12),Gender=true,PhoneNumber = "0372369370",Email="elit.pellentesque@nislNulla.co.uk",Account="Boris" },
                new ClassAdmin(){FullName="Victor Lawrence",DateOfBirth =new System.DateTime(1991,8,2),Gender=false,PhoneNumber = "0928302496",Email="ac@aliquameuaccumsan.co.uk",Account="Yuli" },
                new ClassAdmin(){FullName="Jonas Larson",DateOfBirth =new System.DateTime(1992,03,01),Gender=true,PhoneNumber = "0352265359",Email="porttitor.eros@sit.co.uk",Account="Murphy" },
                new ClassAdmin(){FullName="Marshall Holland",DateOfBirth =new System.DateTime(1997,3,25),Gender=false,PhoneNumber = "0802735142",Email="amet.ultricies@massaQuisque.org",Account="Alvin" }
            };
            context.ClassAdmins.AddRange(classAdmins);
            context.SaveChanges();
        }
    }
}
