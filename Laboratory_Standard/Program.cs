using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace Laboratory_Standard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string mySqlConnectionStr = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<AppDbContext>(options =>
                            options.UseMySql(
                                mySqlConnectionStr,
                                ServerVersion.AutoDetect(mySqlConnectionStr)));
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => options.LoginPath = "/Login/Index");
            builder.Services.AddAuthorization();
            builder.Services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizeFolder("/Logout");
                options.Conventions.AuthorizePage("/Experts/Create");
                options.Conventions.AuthorizePage("/Experts/Delete");

            });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {

                app.UseHsts();
            }

            app.UseHttpsRedirection();


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
