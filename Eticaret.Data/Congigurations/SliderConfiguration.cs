using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Eticaret.Data.Congigurations
{
    class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasColumnType("VARCHAR(100)").HasMaxLength(100);
            builder.Property(x => x.Description).HasColumnType("VARCHAR(500)").HasMaxLength(500);
            builder.Property(x => x.Image).HasColumnType("VARCHAR(250)").HasMaxLength(250);


        }
    }
}
