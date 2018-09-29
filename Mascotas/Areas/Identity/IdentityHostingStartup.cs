using System;
using Mascotas.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Mascotas.Areas.Identity.IdentityHostingStartup))]
namespace Mascotas.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<petsContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("petsContextConnection")));

                services.AddDefaultIdentity<UserIdentity>()
                    .AddEntityFrameworkStores<petsContext>();
            });
        }
    }
}