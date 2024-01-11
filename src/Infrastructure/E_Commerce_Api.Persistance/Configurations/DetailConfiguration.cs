using Bogus;
using E_Commerce_Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce_Api.Persistance.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new Faker("az");
            Detail detail = new Detail()
            {
                CategoryId = 1,
                Description = faker.Lorem.Sentence(5),
                Title = faker.Lorem.Sentence(1),
                CreateDate = DateTime.UtcNow,
                IsDeleted = false,
                Id = 1,
            };
            Detail detail2 = new Detail()
            {
                CategoryId = 3,
                Description = faker.Lorem.Sentence(5),
                Title = faker.Lorem.Sentence(1),
                CreateDate = DateTime.UtcNow,
                IsDeleted = true,
                Id = 2,
            };
            Detail detail3 = new Detail()
            {
                CategoryId = 4,
                Description = faker.Lorem.Sentence(5),
                Title = faker.Lorem.Sentence(1),
                CreateDate = DateTime.UtcNow,
                IsDeleted = false,
                Id = 3,
            };
            builder.HasData(detail, detail2,detail3);
        }
    }
}
