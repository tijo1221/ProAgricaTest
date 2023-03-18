using Microsoft.EntityFrameworkCore;
using ProAgricaTest.Models;

namespace ProAgricaTest.Data
{
    public class UKVisitorsDBContext : DbContext
    {
        public UKVisitorsDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UKVisitor> UKVisitors { get; set; }
    }
}
