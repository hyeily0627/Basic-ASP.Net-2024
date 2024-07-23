using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //Dbcontext ���Ӽ� ����
            builder.Services.AddDbContext<AppDbContext>(Option => Option.UseSqlServer(
                builder.Configuration.GetConnectionString("Myconnection")));

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
                // URL���� : https://localhost:port/controller�̸�/action�̸�/{id}(�ɼ�)
            app.Run();
        }
    }
}
