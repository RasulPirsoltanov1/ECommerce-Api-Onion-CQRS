using Bogus;
using E_Commerce_Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce_Api.Persistance.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);
            Faker faker = new Faker("az");
            for (int i = 1; i < 10; i++)
            {
                builder.HasData(new Brand
                {
                    Id=i,
                    Name = faker.Commerce.Department(),
                    IsDeleted = false,
                    CreateDate = DateTime.UtcNow
                });
            }
            builder.HasData(new Brand
            {
                Id = 10,
                Name = faker.Commerce.Department(),
                IsDeleted = true,
                CreateDate = DateTime.UtcNow
            });
        }
    }
}
