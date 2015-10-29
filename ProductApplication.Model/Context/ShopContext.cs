using System.Data.Entity;
using PA.Core.DataModel.Entities;

namespace PA.Core.DataModel.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext():base("ShopConnectionString")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
