using Microsoft.EntityFrameworkCore;

namespace BuroTek.Entities.Models_0
{
    public class BurotekDbContext : DbContext
    {
        public BurotekDbContext(DbContextOptions<BurotekDbContext> options) : base(options) { }
    }
}
