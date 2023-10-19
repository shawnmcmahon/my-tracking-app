using Microsoft.EntityFrameworkCore;
using tracking.Models;

namespace tracking.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Issue> Issues { get; set; }
    }
}
