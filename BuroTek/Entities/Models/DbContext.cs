using Microsoft.EntityFrameworkCore;

namespace BuroTek.Entities.Models
{
    public class BuroContext : DbContext
    {
        public BuroContext(DbContextOptions<BuroContext> options)
            : base(options)
        {

        }
        public DbSet<Notlar> Notlar { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Evrak> evraks { get; set; }
        public DbSet<Buro> buros { get; set; }
    }
}
