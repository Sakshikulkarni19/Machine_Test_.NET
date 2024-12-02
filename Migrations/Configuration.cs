using System.Data.Entity;
using ProductCategory.Models; // Adjust this based on your actual namespace

namespace ProductCategory
{
    public class ProductCategoryContext : DbContext
    {
        public ProductCategoryContext() : base("name=ProductCategoryContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
