using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyEOrder.Dal.DBContext;
using EasyEOrder.Dal.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EasyEOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                try
                {
                    var userManager = serviceProvider.
                    GetRequiredService<UserManager<MyUser>>();

                    var roleManager = serviceProvider.
                    GetRequiredService<RoleManager<IdentityRole>>();

                    EasyEOrderDbContext.SeedData
                    (userManager, roleManager);
                }
                catch { }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
