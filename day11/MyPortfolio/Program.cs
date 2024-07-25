using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using Westwind.AspNetCore.Markdown; // 마크다운 패키지 추가 

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //             
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // DbContext 종속성 주입
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(
                builder.Configuration.GetConnectionString("MyConnection")
                ));

            // 로그인 세션 설정 
            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "HyejinSession"; // 앱세션 쿠키 이름 ** 쿠키이름 공백 절대 안됨
                options.IdleTimeout = TimeSpan.FromMinutes(20); // 세션지속시간 (20분) 
            }).AddControllersWithViews(); // 세션의 내용을 cshtml에도 적용 

            // 마크다운 관련 설정
            builder.Services.AddMarkdown();
            builder.Services.AddMvc().AddApplicationPart(typeof(MarkdownPageProcessorMiddleware).Assembly);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseMarkdown(); // 마크다운 사용설정 

            app.UseHttpsRedirection();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                // URL패턴 : https://localhost:port/controller이름/action이름/[id](옵션)

            app.Run();
        }
    }
}
