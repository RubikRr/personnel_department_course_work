using Microsoft.EntityFrameworkCore;
using personnel_department_DB;
using personnel_department_DB.Interfaces;
using personnel_department_DB.Storages;

namespace personnel_department_course_work
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString =builder.Configuration.GetConnectionString("PersonnelDepartment");
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddTransient<IPositionsStorage,PositionsStorage>();
            builder.Services.AddTransient<IEmployeesStorage, EmployeesStorage>();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}