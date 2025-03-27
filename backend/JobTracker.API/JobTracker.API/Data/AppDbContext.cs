using Microsoft.EntityFrameworkCore;

namespace JobTracker.API.Data
{
    public class AppDbContext : DbContext
    {
        private readonly AppDbContext _context;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
