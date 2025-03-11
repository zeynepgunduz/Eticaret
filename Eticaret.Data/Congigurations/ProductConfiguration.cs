using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Eticaret.Data.Congigurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(100)").HasMaxLength(100);
            builder.Property(x => x.Description).HasColumnType("VARCHAR(500)").HasMaxLength(500);
            builder.Property(x => x.Image).HasColumnType("VARCHAR(250)").HasMaxLength(250);
            builder.Property(x => x.Price).IsRequired().HasColumnType("DECIMAL(18,2)");
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsHome).IsRequired();
  
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.HasData
                (
                new Product
                {
                    Id = 1,
                    Name = "Product1",
                    Description = "Product1 Description",
                    Image = "1.jpg",
                    Price = 100,
                    IsActive = true,
                    IsHome = true,
                    Stock = 100,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Product2",
                    Description = "Product2 Description",
                    Image = "2.jpg",
                    Price = 200,
                    IsActive = true,
                    IsHome = true,
                    Stock = 200,
                    CategoryId = 2
                }
                );
        }
    }
}
