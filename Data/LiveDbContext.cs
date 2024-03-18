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
        public DbSet<Address> Addresss { get; set; }
        public DbSet<Conection> Conections { get; set; }
        public DbSet<CellPlan> CellPlans { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Status> Statuss { get; set; }





    }
}
