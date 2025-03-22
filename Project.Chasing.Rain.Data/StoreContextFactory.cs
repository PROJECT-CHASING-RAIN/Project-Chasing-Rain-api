using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Project.Chasing.Rain.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();
        optionsBuilder.UseSqlite("Data Source = ../Registrar.dqlite");
        return new StoreContext(optionsBuilder.Options);
    }
}