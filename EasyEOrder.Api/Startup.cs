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

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.Configure<IdentityOptions>(options =>
            {
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
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
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseExceptionHandler("/error"); // Add this
            app.UseSession();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseHttpsRedirection();

            app.UseRouting();

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
        }
    }
}
