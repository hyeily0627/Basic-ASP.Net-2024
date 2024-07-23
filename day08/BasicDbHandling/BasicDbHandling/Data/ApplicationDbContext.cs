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

        // CodeFirst로 만들어준 엔티티 클래스를 작성, 테이블 생성할 엔터티가 증가할 수록 여기 입력해야함. 
        public DbSet<Category> Categories { get; set; }
    }
}
