using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Congigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
               builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Description).HasColumnType("VARCHAR(500)").HasMaxLength(500);
            builder.Property(x => x.Image).HasColumnType("VARCHAR(250)").HasMaxLength(250);
            //builder.HasData(

            //    new Category
            //    {
            //        Id = 1,
            //        Name = "Elektronik",
            //        Description = "Category1 Description",
            //        Image = "1.jpg",
            //        IsActive = true,
            //        IsTopMenu = true,
            //        ParentId = 0,
            //        OrderNo = 1,
            //    },
            //    new Category
            //    {
            //        Id = 2,
            //        Name = "Bilgisayar",
            //        Description = "Category2 Description",
            //        Image = "2.jpg",
            //        IsActive = true,
            //        IsTopMenu = true,
            //        ParentId = 0,
            //        OrderNo = 2,
            //    }
            //    );
        }
    }
}
