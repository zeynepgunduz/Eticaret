using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Eticaret.Data.Congigurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Description).HasColumnType("VARCHAR(500)").HasMaxLength(500);
            builder.Property(x => x.Logo).HasColumnType("VARCHAR(250)").HasMaxLength(250);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.OrderNo).IsRequired();
          //  builder.Property(x => x.CreateDate).IsRequired();
            //builder.HasData(
            //    new Brand
            //    {
            //        Id = 1,
            //        Name = "Brand1",
            //        Description = "Brand1 Description",
            //        IsActive = true,
            //        OrderNo = 1,
            //        CreateDate = new DateTime(2020, 12, 10)
            //    },
            //    new Brand
            //    {
            //        Id = 2,
            //        Name = "Brand2",
            //        Description = "Brand2 Description",
            //        IsActive = true,
            //        OrderNo = 2,
            //        CreateDate = new DateTime(2020, 12, 10)
            //    }
            //);
        }
    }
}
