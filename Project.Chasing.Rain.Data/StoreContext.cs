using Project.Chasing.Rain.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Project.Chasing.Rain.Domain.Order;

namespace Project.Chasing.Rain.Data
{
    // Represents the database context for the application
    public class StoreContext : DbContext
    {
        // Constructor to initialize the DbContext with options
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {}

        // Represents the Items table in the database
        public DbSet<Item> Items { get; set; }
        public DbSet <Order> Orders {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}