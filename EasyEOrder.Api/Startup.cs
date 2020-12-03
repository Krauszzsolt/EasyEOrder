using EasyEOrder.Api.Helpers;
using EasyEOrder.Api.Helpers;
using EasyEOrder.Bll.Helpers;
using EasyEOrder.Bll.Interfaces;
using EasyEOrder.Bll.Services;
using EasyEOrder.Dal.DBContext;
using EasyEOrder.Dal.Entities;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using System.Threading.Tasks;

namespace EasyEOrder
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<EasyEOrderDbContext>(options =>
             options.UseSqlServer(
                 Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<MyUser, IdentityRole>()
                .AddEntityFrameworkStores<EasyEOrderDbContext>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IFoodService, FoodService>();
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<ICartService, CartService>();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            });
            services.AddSwaggerDocument(settings =>
            {
                settings.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "Example API";
                    document.Info.Description = "REST API for example.";
                };
            });

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
            });

            services.AddAuthentication()
             .AddJwtBearer();
            services.AddAuthorization();
            services.AddCors();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseExceptionHandler("/error"); // Add this

            app.UseSession();

            app.UseOpenApi();

            app.UseSwaggerUi3();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseExceptionHandler("/error"); //Error handler Controller

            app.UseCors(x => x
             .AllowAnyMethod()
             .AllowAnyHeader()
             .SetIsOriginAllowed(origin => true) // allow any origin
             .AllowCredentials()); // allow credentials

            app.UseMiddleware<JwtMiddleware>();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            CreateRoles(serviceProvider);
        }

        private void CreateRoles(IServiceProvider serviceProvider)
        {
            // roles
            var adminRole = "Administrator";
            var userRole = "User";

            // managers
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<MyUser>>();

            // check that there is an Administrator role and create if not

            var hasAdminRole = roleManager.RoleExistsAsync(adminRole);
            hasAdminRole.Wait();
            if (!hasAdminRole.Result)
            {
                var roleResult = roleManager.CreateAsync(new IdentityRole(adminRole));
                roleResult.Wait();
            }

            var hasUserRole = roleManager.RoleExistsAsync(userRole);
            hasUserRole.Wait();
            if (!hasUserRole.Result)
            {
                var roleResult = roleManager.CreateAsync(new IdentityRole(userRole));
                roleResult.Wait();
            }

            // add to the Administrator role

            string userName = "admin";
            var testUser = userManager.FindByNameAsync(userName);
            testUser.Wait();

            if (testUser.Result == null)
            {
                var administrator = new MyUser()
                {
                    UserName = userName
                };

                var newUser = userManager.CreateAsync(administrator, "password123");
                newUser.Wait();

                if (newUser.Result.Succeeded)
                {
                    var newUserRole = userManager.AddToRoleAsync(administrator, adminRole);
                    newUserRole.Wait();
                }
            }
        }

    }
}
