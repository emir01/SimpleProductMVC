using System.Data.Entity;
using PA.Model.Entities;

namespace PA.Model.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext():base("ShopConnectionString")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
