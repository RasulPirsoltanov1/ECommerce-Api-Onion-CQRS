using Bogus;
using E_Commerce_Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new Faker("az");
            Product product = new Product()
            {
                Id=1,
                BrandId = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Discount = faker.Random.Decimal(1, 10),
                Price = faker.Finance.Amount(10, 1000),
            };
            Product product2 = new Product()
            {
                Id = 2,

                BrandId = 3,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Discount = faker.Random.Decimal(1, 10),
                Price = faker.Finance.Amount(10, 1000),
            };
            builder.HasData(product,product2);
        }
    }
}
