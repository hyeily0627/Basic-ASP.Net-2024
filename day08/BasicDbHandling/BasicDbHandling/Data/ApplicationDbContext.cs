using BasicDbHandling.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicDbHandling.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // 내용X
        }

        // CodeFirst로 만들어준 엔티티 클래스를 작성
        public DbSet<Category> Categories { get; set; }
    }
}
