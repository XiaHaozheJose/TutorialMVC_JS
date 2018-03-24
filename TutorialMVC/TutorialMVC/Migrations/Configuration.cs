namespace TutorialMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TutorialMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TutorialMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(
                new Products
                {
                    ProductID = 1,
                    Description =  "TV",
                    Brand = "Samsung",
                    Quantity = 1,
                    price = 500.99, 
                },
                new Products
                 {
                ProductID = 2,
                Description = "Movil",
                Brand = "Apple",
                Quantity = 1,
                price = 899.99,
            }
                );

        }
    }
}
