using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MemoEngine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // SuspiciousActivityReport 테이블을 추가합니다.
        //public DbSet<MemoEngine.Models.SuspiciousActivityReport> SuspiciousActivityReports { get; set; }
    }
}
