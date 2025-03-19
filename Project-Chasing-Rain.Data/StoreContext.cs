using Microsoft.EntityFrameworkCore;
using Project.Chasing.Rain.Domain.Catalog;

namespace Project_Chasing_Rain.Data
{

    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }
    }
}
