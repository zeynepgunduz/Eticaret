using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Eticaret.Data.Congigurations
{
    class NewsConfiguration : IEntityTypeConfiguration<News>
    {
   
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(100)").HasMaxLength(100);
            builder.Property(x => x.Description).HasColumnType("VARCHAR(500)").HasMaxLength(500);
            builder.Property(x => x.Image).HasColumnType("VARCHAR(250)").HasMaxLength(250);
            builder.Property(x => x.IsActive).IsRequired();

            //builder.HasData
            //    (

            //    new News
            //    {
            //        Id = 1,
            //        Name = "Haber1",
            //        Description = "Haber1 Description",
            //        Image = "1.jpg",
            //        IsActive = true,

            //    });
        }
    }
}
