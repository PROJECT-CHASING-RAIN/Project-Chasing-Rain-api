using Project.Chasing.Rain.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project.Chasing.Rain.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
             builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State shirt", "Nike", 29.99m)
                {
                    Id = 1
                },
                new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
                {
                    Id = 2
                }
             );

        }
    }
}