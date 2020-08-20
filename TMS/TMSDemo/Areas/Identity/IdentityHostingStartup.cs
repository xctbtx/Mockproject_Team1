using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TMS.ClassAdminManagement.Model;

[assembly: HostingStartup(typeof(TMSDemo.Areas.Identity.IdentityHostingStartup))]
namespace TMSDemo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AdminContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AdminConn")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AdminContext>();
            });
        }
    }
}