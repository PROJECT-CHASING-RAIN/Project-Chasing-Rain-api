using Project.Chasing.Rain.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project.Chasing.Rain.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}