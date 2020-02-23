using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using CarRental.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public  IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<DatabaseContext>();
            services.Configure<IdentityOptions>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 0;
            });
            services.AddScoped<IAdditionalEquipmentRepository, AdditionalEquipmentRepository>();
            services.AddScoped<IArchivesRepository, ArchivesRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IRentReposiotry, RentRepository>();
        }

        private async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            // Initializing custom roles   
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            IdentityResult roleResult;

            // Adding Admin Role
            var roleCheck = await RoleManager.RoleExistsAsync("Admin");
            if (!roleCheck)
            {
                //Create the roles and seed them to the database 
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }

            roleCheck = await RoleManager.RoleExistsAsync("User");
            if (!roleCheck)
            {
                //Create the roles and seed them to the database 
                roleResult = await RoleManager.CreateAsync(new IdentityRole("User"));
            }
            roleCheck = await RoleManager.RoleExistsAsync("Employee");
            if (!roleCheck)
            {
                //Create the roles and seed them to the database 
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Employee"));
            }

            // Assign Admin role to newly registered user
            //AppUser user = await UserManager.FindByNameAsync("Admin");
            //var User = new AppUser();
            //await UserManager.AddToRoleAsync(user, "Admin");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider service)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            CreateUserRoles(service).Wait();
        }


    }
}
