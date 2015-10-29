using System.Data.Entity;
using PA.DataModel.Entities;

namespace PA.DataModel.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext():base("ShopConnectionString")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
