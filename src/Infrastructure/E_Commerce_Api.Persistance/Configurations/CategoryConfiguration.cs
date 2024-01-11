using E_Commerce_Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce_Api.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new Category
            {
                Name = "Electric",
                Id = 1,
                Priorty = 1,
                ParentId = 0,
                IsDeleted = false,
                CreateDate = DateTime.UtcNow,
            };
            Category category2 = new Category
            {
                Id = 2,
                Name = "Moda",
                Priorty = 2,
                ParentId = 0,
                IsDeleted = false,
                CreateDate = DateTime.UtcNow,
            };
            Category parent1 = new Category
            {
                Id = 3,
                Name = "Computers",
                Priorty = 1,
                ParentId = 1,
                IsDeleted = false,
                CreateDate = DateTime.UtcNow,
            };
            Category parent2 = new Category
            {
                Id = 4,
                Name = "Women",
                Priorty = 1,
                ParentId = 2,
                IsDeleted = false,
                CreateDate = DateTime.UtcNow,
            };
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}
