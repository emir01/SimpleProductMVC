using System.Data.Entity.Migrations;
using PA.DataModel.Context;
using PA.DataModel.Entities;

namespace PA.DataModel.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopContext context)
        {
            context.Products.Add(new Product()
            {
                Category = "Bike",
                Name = "Mountain Bike Trek x9",
                Description = "For mountain/trail riding",
                Price = 200,
                Quantity = 10
            });

            context.Products.Add(new Product()
            {
                Category = "Coffee Cup",
                Name = "Red Coffee Cup",
                Description = "Coffee cup with a white image of the New York Skyline",
                Price = 20,
                Quantity = 15
            });

            context.Products.Add(new Product()
            {
                Category = "Cooking",
                Name = "Knife set x6",
                Description = "Eating knife set",
                Price = 80,
                Quantity = 2
            });

            context.Products.Add(new Product()
            {
                Category = "Bike",
                Name = "Road Bike Specialized H10",
                Description = "For road/tarmac riding",
                Price = 400,
                Quantity = 2
            });

            context.Products.Add(new Product()
            {
                Category = "Drawing",
                Name = "Water Coloring Set",
                Description = "Complete water coloring set for canvas painting",
                Price = 30,
                Quantity = 3
            });

            context.Products.Add(new Product()
            {
                Category = "Drawing",
                Name = "Pencil Set",
                Description = "Set of pencils for simple drawings",
                Price = 15,
                Quantity = 2
            });
        }
    }
}
