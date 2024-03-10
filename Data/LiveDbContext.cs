using live.Models;
using Microsoft.EntityFrameworkCore;

namespace live.Data
{
    public class LiveDbContext : DbContext
    {
        public LiveDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Localtion> Localtions { get; set; }



    }
}
