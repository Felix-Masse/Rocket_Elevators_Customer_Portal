using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RocketElevator_Customer.Areas.Identity.Data;
using RocketElevator_Customer.Data;

[assembly: HostingStartup(typeof(RocketElevator_Customer.Areas.Identity.IdentityHostingStartup))]
namespace RocketElevator_Customer.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RocketElevator_CustomerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RocketElevator_CustomerContextConnection")));

                services.AddDefaultIdentity<CustomerUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<RocketElevator_CustomerContext>();
            });
        }
    }
}