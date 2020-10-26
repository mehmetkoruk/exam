using System;
using examlast.Areas.Identity.Data;
using examlast.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(examlast.Areas.Identity.IdentityHostingStartup))]
namespace examlast.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<examlastContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("examlastContextConnection")));

                services.AddDefaultIdentity<examlastUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<examlastContext>();
            });
        }
    }
}