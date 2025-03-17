using Project_Chasing_Rain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project_Chasing_Rain.Data{
public class StoreContext : DbContext{

    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {

    }
    public Dbset<Item> Items { get; set; }
}
}