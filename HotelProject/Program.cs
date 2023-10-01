using HotelProject.Factory;
using HotelProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace HotelProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<HotelDbContext>(options =>
            {
                options.UseMySQL("server=127.0.0.1;database=hoteldb;uid=root;pwd=root");
            });

            builder.Services.AddDbContext<UserDbContext>(options =>
            {
                options.UseMySQL("server=127.0.0.1;database=hoteldb;uid=root;pwd=root");
            });

            builder.Services.AddScoped<IUserClaimsPrincipalFactory<User>, CustomClaimsFactory>();

            builder.Services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 5;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<UserDbContext>();

            builder.Services.AddAutoMapper(typeof(Program));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "hotel",
                    pattern: "hotel/{action=Index}/{id?}",
                    defaults: new { controller = "Hotel" }
                );
            });

            app.Run();
        }
    }
}