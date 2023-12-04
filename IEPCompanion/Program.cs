using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IEPCompanion.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.Extensions.Logging;


// be sure to change the namespace to match your project
namespace IEPCompanion
  {
    class Program
    {
      static void Main(string[] args)
      {
        
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<IEPCompanionContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

      // Adds identity roles to the database.
        builder.Services.AddDefaultIdentity<ApplicationUser>()
          .AddRoles<IdentityRole>()
          .AddEntityFrameworkStores<IEPCompanionContext>();
        

        builder.Services.AddAuthorization(options =>
        {
          options.AddPolicy("RequireAdministratorRole",
                          policy => policy.RequireRole("admin"));
          options.AddPolicy("RequireTeacherRole",
                          policy => policy.RequireRole("teacher"));
          options.AddPolicy("RequireParentRole",
                          policy => policy.RequireRole("parent"));
        });
        builder.Services.AddControllersWithViews();

        // be sure to update the line below for your project
        builder.Services.AddDbContext<IEPCompanionContext>(
          dbContextOptions => dbContextOptions
            .UseMySql(
              builder.Configuration["ConnectionStrings:DefaultConnection"],
              ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
            )
        );


        // This is where we can determine Password requirements for users.
        builder.Services.Configure<IdentityOptions>(options =>
        {
          options.Password.RequireDigit = true;
          options.Password.RequireLowercase = true;
          options.Password.RequireNonAlphanumeric = true;
          options.Password.RequireUppercase = true;
          options.Password.RequiredLength = 6;
          options.Password.RequiredUniqueChars = 1;
        });

        var app = builder.Build();


        app.UseDeveloperExceptionPage();
        app.UseStaticFiles();

        app.UseRouting();

        // Next two lines below enable authentication and authorization.
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
          name: "default",
          pattern: "{controller=Home}/{action=Index}/{id?}"
        );

        // Regarding scope of roles, this is where we can add roles to the database.
      

        app.Run();
      }
    }
  }

