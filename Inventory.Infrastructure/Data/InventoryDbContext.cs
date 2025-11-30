using Inventory.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Data
{
    public class InventoryDbContext : DbContext
    {
        // This constructor passes configuration (like connection strings) to the base class
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        // This line tells .NET: "I want a table in SQL called 'Products' based on the 'Product' class"
        public DbSet<Product> Products { get; set; }
    }
}