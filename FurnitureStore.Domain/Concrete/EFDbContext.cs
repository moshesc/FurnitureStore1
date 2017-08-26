using FurnitureStore.Domain.Entities;
using System.Data.Entity;

namespace FurnitureStore.Domain.Concrete
{
    class EFDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
