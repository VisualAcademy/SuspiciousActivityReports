using MemoEngine.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoEngine.Data
{
    public class TenantDbContext : DbContext
    {
        public TenantDbContext(DbContextOptions<TenantDbContext> options) : base(options)
        {
        }

        public DbSet<SuspiciousActivityReport> SuspiciousActivityReports { get; set; }
    }
}
