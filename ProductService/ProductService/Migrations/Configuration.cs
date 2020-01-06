namespace ProductService.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductService.Models.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductService.Models.ProductDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.Add(new Models.Product
                {
                    Name = "Avocado",
                    Price = 5,
                    Count = 11
                });
            }
        }
    }
}
