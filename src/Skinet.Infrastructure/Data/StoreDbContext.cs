using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Skinet.Core.Domain.Entities;

namespace Skinet.Infrastructure.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductBrand> ProductBrands { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Bind the DbSet properties to the self-named tables
            // modelBuilder.Entity<Product>().ToTable("Products");

            // Configure using the Product configuration class
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Brands seed data
            string brandsData = File.ReadAllText("../Skinet.Infrastructure/Data/SeedData/brands.json");
            List<ProductBrand> brands = System.Text.Json.JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

            foreach (ProductBrand brand in brands)
            {
                modelBuilder.Entity<ProductBrand>().HasData(brand);
            }

            // Types seed data
            string typesData = File.ReadAllText("../Skinet.Infrastructure/Data/SeedData/types.json");
            List<ProductType> types = System.Text.Json.JsonSerializer.Deserialize<List<ProductType>>(typesData);

            foreach (ProductType type in types)
            {
                modelBuilder.Entity<ProductType>().HasData(type);
            }

            // Products seed data
            string productsData = File.ReadAllText("../Skinet.Infrastructure/Data/SeedData/products.json");
            List<Product> products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(productsData);

            foreach (Product product in products)
            {
                modelBuilder.Entity<Product>().HasData(product);
            }
        } 
    }
}