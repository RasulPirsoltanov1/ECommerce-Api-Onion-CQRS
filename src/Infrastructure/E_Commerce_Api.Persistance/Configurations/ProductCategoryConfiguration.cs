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
    internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.HasOne(x=>x.Product).WithMany(x=>x.ProductCategories).HasForeignKey(x=>x.ProductId).OnDelete(deleteBehavior:DeleteBehavior.Cascade);
            builder.HasOne(x => x.Category).WithMany(x => x.ProductCategories).HasForeignKey(x=>x.CategoryId).OnDelete(deleteBehavior: DeleteBehavior.Cascade); ;
        }
    }
}
